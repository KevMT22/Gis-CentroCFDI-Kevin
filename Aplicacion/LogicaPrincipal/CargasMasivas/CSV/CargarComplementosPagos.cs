﻿using API.Enums;
using API.Enums.CartaPorteEnums;
using API.Operaciones.ComplementosPagos;
using API.Operaciones.Facturacion;
using API.Relaciones;
using Aplicacion.Context;
using Aplicacion.LogicaPrincipal.GeneracionComplementosPagos;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;

namespace Aplicacion.LogicaPrincipal.CargasMasivas.CSV
{
    public class CargarComplementosPagos
    {

        #region Variables

        private readonly AplicacionContext _db = new AplicacionContext();
        private readonly PagosManager _pagosManager = new PagosManager();

        #endregion

        public List<ComplementoPago> Importar(string path, int sucursalId, Meses mes, bool previsualizacion)
        {
            var errores = new List<String>();
            double equivalencia = 1;
            var complementosPago = new List<ComplementoPago>();
            using (StreamReader archivo = File.OpenText(path))
            {
                try
                {
                    var csv = new CsvReader(archivo);

                    var registros = new List<List<String>>();
                    var sucursal = _db.Sucursales.Find(sucursalId);
                    var time = DateTime.Now;
                    while (csv.Read())
                    {
                        var registro = new List<String>();
                        for (int i = 0; csv.TryGetField(i, out string value); i++)
                        {
                            registro.Add(value);
                        }
                        registros.Add(registro);
                    }

                    var pagos = new List<Pago>();

                    for (int i = 1; i < registros.Count(); i++)
                    {
                        try
                        {
                            
                            var fechaPago = Convert.ToDateTime(registros[i][0]);
                            fechaPago = fechaPago.Date.AddHours(time.Hour).AddMinutes(time.Minute).AddSeconds(00);
                            var formaPago = ConvertFormaPagoValid(registros[i][1]);
                            var monto = Convert.ToDouble(registros[i][2]);
                            var moneda = ParseEnum<c_Moneda>(registros[i][3], i);
                            var tipoCambioPago = Convert.ToDouble(registros[i][4]);
                            var equivalenciaDR = Convert.ToDouble(registros[i][5]);
                            var numeroOperacion = registros[i][6];
                            if (String.IsNullOrEmpty(numeroOperacion))
                            {
                                numeroOperacion = null;
                            }


                            var serie = registros[i][10];
                            var folio = registros[i][11];
                            //usar solo con facturasEmitidas
                            //var facturaEmitida = _db.FacturasEmitidas.FirstOrDefault(fe => fe.EmisorId == sucursalId && fe.Serie == serie && fe.Folio == folio);
                            //activar para FacturasEmitidasTemp
                            var facturaEmitida = _db.FacturasEmitidasTemp.FirstOrDefault(fe => fe.EmisorId == sucursalId && fe.Serie == serie && fe.Folio == folio);
                            if (facturaEmitida == null)
                            {
                                errores.Add(String.Format("La factura {0} - {1} no fue encontrada para el registro {2}", serie, folio, i));
                                continue;
                            }
                            var facturaEmitidaCop = _db.FacturasEmitidas.Find(facturaEmitida.Id);
                            
                            //Se desorganizaron los numeros por que necesito el cliente para determinar el banco
                            var nombreBancoOrdenante = registros[i][7];
                            BancoCliente bancoOrdenante = null;
                            if (!String.IsNullOrEmpty(nombreBancoOrdenante))
                            {
                                bancoOrdenante = _db.BancosClientes.FirstOrDefault(b => b.Nombre == nombreBancoOrdenante && b.Cliente.SucursalId == sucursalId && b.ClienteId == facturaEmitida.ReceptorId);
                                if (bancoOrdenante == null)
                                {
                                    errores.Add(String.Format("El banco {0} no fue encontrado para el registro {1}", nombreBancoOrdenante, i));
                                    continue;
                                }
                            }

                            var nombreBancoBeneficiario = registros[i][8];
                            BancoSucursal bancoBeneficiario = null;
                            if (!String.IsNullOrEmpty(nombreBancoBeneficiario))
                            {
                                bancoBeneficiario = _db.BancosSucursales.FirstOrDefault(b => b.Nombre == nombreBancoBeneficiario && b.SucursalId == sucursalId);
                                if (bancoBeneficiario == null)
                                {
                                    errores.Add(String.Format("El banco {0} no fue encontrado para el registro {1}", nombreBancoBeneficiario, i));
                                    continue;
                                }
                            }

                            var numeroParcialidad = registros[i][9];
                            

                            var importePagado = String.IsNullOrEmpty(registros[i][12]) ? facturaEmitida.Total : Convert.ToDouble(registros[i][12]);
                            var importeSaldoAnterior = String.IsNullOrEmpty(registros[i][13]) ? facturaEmitida.Total : Convert.ToDouble(registros[i][13]);
                            var importeSaldoInsoluto = String.IsNullOrEmpty(registros[i][14]) ? 0.0 : Convert.ToDouble(registros[i][14]);

                            #region Pagos

                            #region Documentos Relacionados
                            
                            var documentoRelacionado = new DocumentoRelacionado
                            {
                                FacturaEmitidaId = facturaEmitida.Id,
                                FacturaEmitida = facturaEmitidaCop,
                                Folio = facturaEmitida.Folio,
                                IdDocumento = facturaEmitida.Uuid,
                                ImportePagado = importePagado,
                                ImporteSaldoAnterior = importeSaldoAnterior,
                                ImporteSaldoInsoluto = importeSaldoInsoluto,
                               // MetodoPago = (c_MetodoPago)facturaEmitida.MetodoPago,
                                Moneda = facturaEmitida.Moneda,
                                NumeroParcialidad = Convert.ToInt32(String.IsNullOrEmpty(numeroParcialidad) ? "1" : numeroParcialidad),
                                Serie = facturaEmitida.Serie,
                                EquivalenciaDR = equivalenciaDR,
                                ObjetoImpuestoId = "01"
                            };

                            #endregion

                            if (pagos.Any(p => p.NumeroOperacion == numeroOperacion && p.FechaPago == fechaPago && p.Monto == monto && p.DocumentosRelacionados.Any(dr => dr.FacturaEmitida.ReceptorId == documentoRelacionado.FacturaEmitida.ReceptorId)))
                            {
                                pagos.First(p => p.NumeroOperacion == numeroOperacion && p.FechaPago == fechaPago && p.Monto == monto && p.DocumentosRelacionados.Any(dr => dr.FacturaEmitida.ReceptorId == documentoRelacionado.FacturaEmitida.ReceptorId)).DocumentosRelacionados.Add(documentoRelacionado);
                            }
                            else
                            {
                                var pago = new Pago
                                {
                                    FechaPago = fechaPago,
                                    FormaPago = formaPago.ToString(),
                                    Moneda = moneda,
                                    Monto = monto,
                                    NumeroOperacion = numeroOperacion,
                                    SucursalId = sucursalId,
                                    TipoCambio = tipoCambioPago,
                                    
                                };

                                if (bancoOrdenante != null)
                                {
                                    pago.BancoOrdenante = bancoOrdenante;
                                    pago.BancoOrdenanteId = bancoOrdenante.Id;
                                }

                                if (bancoBeneficiario != null)
                                {
                                    pago.BancoBeneficiario = bancoBeneficiario;
                                    pago.BancoBeneficiarioId = bancoBeneficiario.Id;
                                }

                                if (pago.DocumentosRelacionados == null)
                                {
                                    pago.DocumentosRelacionados = new List<DocumentoRelacionado>();
                                }

                                pago.DocumentosRelacionados.Add(documentoRelacionado);

                                pagos.Add(pago);
                            }


                            #endregion
                        }
                        catch (Exception ex)
                        {
                            errores.Add(String.Format("No se pudo procesar el registro {0} el motivo reportado: {1} </br>", i, ex.Message));
                            continue;
                        }
                    }

                    foreach (var pago in pagos)
                    {
                        
                        var receptor = pago.DocumentosRelacionados.FirstOrDefault().FacturaEmitida.Receptor;
                        if(receptor == null)
                        {
                            errores.Add(String.Format("El pago {0} no tiene documentos relacionados", pago.Desplegado));
                        }
                        
                        var complementoPago = complementosPago.FirstOrDefault(cp => cp.ReceptorId == receptor.Id);
                        if(complementoPago == null)
                        {
                            complementoPago = new ComplementoPago
                            {
                                FechaDocumento = DateTime.Now,
                                Generado = false,
                                ReceptorId = receptor.Id,
                                Receptor = receptor,
                                Status = Status.Activo,
                                Mes = mes,
                                SucursalId = sucursal.Id,
                                Sucursal = sucursal,
                                Version = "2.0",
                                Pagos = new List<Pago> { pago },
                                ExportacionId = "01"
                            };
                            complementosPago.Add(complementoPago);
                        }
                        else
                        {
                            complementoPago.Pagos.Add(pago);
                        }
                    }
                }
                catch (Exception ex)
                {
                    errores.Add(ex.Message);
                }
                finally
                {
                    archivo.Close();
                    archivo.Dispose();
                }
            }

            if(errores.Count > 0)
            {
                throw new Exception(String.Join("|", errores));
            }

            if (!previsualizacion)
            {
                foreach (var complementoPago in complementosPago)
                {
                    _db.ComplementosPago.Add(complementoPago);
                    try
                    {
                       
                        decimal totalRetencionesISR = 0;
                        decimal totalRetencionesIVA = 0;
                        decimal totalRetencionesIEPS = 0;
                        decimal totalTrasladosBaseIVA16 = 0;
                        decimal totalTrasladosImpuestoIVA16 = 0;
                        decimal totalTrasladosBaseIVA8 = 0;
                        decimal totalTrasladosImpuestoIVA8 = 0;
                        decimal totalTrasladosBaseIVA0 = 0;
                        decimal totalTrasladosImpuestoIVA0 = 0;
                        decimal totalTrasladosBaseIVAExento = 0;

                        
                        double montoTPagos = 0;
                        if (complementoPago.Pagos != null)
                        {
                            
                            foreach (var pg in complementoPago.Pagos)
                            {
                                if (pg.Moneda.ToString() != "MXN")
                                {
                                    montoTPagos += pg.TipoCambio * pg.Monto;
                                }
                                else { montoTPagos += pg.Monto; }
                                
                            }

                        }


                        //Totales Pagos Impuestos
                       
                        complementoPago.TotalesPagosImpuestos = new TotalesPagosImpuestos()
                        {
                           TotalRetencionesIVA = Decimal.ToDouble(totalRetencionesIVA),
                           TotalRetencionesISR = Decimal.ToDouble(totalRetencionesISR),
                           TotalRetencionesIEPS = Decimal.ToDouble(totalRetencionesIEPS),
                           TotalTrasladosBaseIVA16 = Decimal.ToDouble(totalTrasladosBaseIVA16),
                           TotalTrasladosBaseIVA8 = Decimal.ToDouble(totalTrasladosBaseIVA8),
                           TotalTrasladosBaseIVA0 = Decimal.ToDouble(totalTrasladosBaseIVA0),
                           TotalTrasladosImpuestoIVA16 = Decimal.ToDouble(totalTrasladosImpuestoIVA16),
                           TotalTrasladosImpuestoIVA8 = Decimal.ToDouble(totalTrasladosImpuestoIVA8),
                           TotalTrasladosImpuestoIVA0 = Decimal.ToDouble(totalTrasladosImpuestoIVA0),
                           TotalTrasladosBaseIVAExento = Decimal.ToDouble(totalTrasladosBaseIVAExento),
                           MontoTotalPagos = montoTPagos
                    };
                        
                        _db.SaveChanges();
                       
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                errores.Add(String.Format("Propiedad: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                            }
                        }
                    }
                }

            }

            return complementosPago;
        }

        public String Exportar()
        {
            var path = String.Format(AppDomain.CurrentDomain.BaseDirectory + "//Content//Temp//LayoutComplementos_{0}.csv", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            #region Encabezados

            var encabezados = new List<String>
            {
                "*Fecha de Pago",
                "*Forma de Pago",
                "*Monto",
                "*Moneda",
                "*Tipo de cambio del dia del pago para moneda del pago",
                "*EquivalenciaDR",
                "*Numero de Operacion",
                "Banco Ordenante",
                "Banco Beneficiario",
                "*Numero de Parcialidad",
                "*Serie de la Factura",
                "*Folio de la Factura",
                "Importe Pagado",
                "Importe Saldo Anterior",
                "Importe Saldo Insoluto"
            };

            #endregion

            #region Registros

            #endregion

            using (var textWriter = File.CreateText(path))
            {
                using (var csv = new CsvWriter(textWriter))
                {
                    csv.WriteField(encabezados);
                }
                textWriter.Close();
            }

            return path;
        }

        #region Funciones Internas

        private T ParseEnum<T>(string valor, int registro)
        {
            var esNumero = int.TryParse(valor, out int numero);
            if (esNumero)
            {
                return (T)Enum.Parse(typeof(T), valor);
            }
            else
            {
                try
                {
                    if (String.IsNullOrEmpty(valor))
                    {
                        return default(T);
                    }
                    return (T)Enum.Parse(typeof(T), valor, true);
                }
                catch (Exception)
                {
                    throw new Exception(String.Format("No se pudo convertir el texto {0} en la propiedad {1} para el registro {2}", valor, typeof(T), registro));
                }
            }
        }

        private String ConvertFormaPagoValid(string formaPago)
        {
            String formaPagoValid = "03";

            if (formaPago.Length < 2)
            {
                switch (formaPago)
                {
                    case "1":
                        formaPagoValid = "01";
                        break;
                    case "2":
                        formaPagoValid = "02";
                        break;
                    case "3":
                        formaPagoValid = "03";
                        break;
                    case "4":
                        formaPagoValid = "04";
                        break;
                    case "5":
                        formaPagoValid = "05";
                        break;
                    case "6":
                        formaPagoValid = "06";
                        break;
                    case "8":
                        formaPagoValid = "08";
                        break;
                    default:
                        formaPagoValid = "03";
                        break;
                }

            }
            else
            {
                formaPagoValid = formaPago;
            }
            return formaPagoValid;
        }
        #endregion
    }
}
