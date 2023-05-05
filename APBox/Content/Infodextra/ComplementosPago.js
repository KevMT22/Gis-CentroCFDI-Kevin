﻿$(function () {
    $("#agregarDetalle").on('click', function () {
        //var x;
        //var file = document.getElementById('file').files[0];
        //if (file) {
        //    var reader = new FileReader();
        //    reader.readAsText(file);
        //    reader.onload = function (e) {
        //        $.ajax({
        //            type: 'POST',
        //            url: '../AjaxOperaciones/AgregarPago',
        //            data: JSON.stringify({ fechaPago: $('#Pago_FechaPago').val(), formaPago: $('#Pago_FormaPago').val(), moneda: $('#Pago_Moneda').val(), tipoCambio: $('#Pago_TipoCambio').val(), monto: $('#Pago_Monto').val(), numeroOperacion: $('#Pago_NumeroOperacion').val(), tipoCadenaPago: $('#Pago_TipoCadenaPago').val(), certificadoPago: $('#Pago_CertificadoPago').val(), cadenaPago: $('#Pago_CadenaPago').val(), selloPago: $('#Pago_SelloPago').val(), spei: e.target.result, bancoEmisorId: $('#Pago_BancoOrdenanteId').val(), bancoReceptorId: $('#Pago_BancoBeneficiarioId').val() }),
        //            dataType: 'html',
        //            contentType: "application/json; charset=utf-8",
        //        }).success(function (partialView) {
        //            $('#detalles').append(partialView);
        //        })
        //            .fail(function (jqxhr, textStatus, error) {
        //                alert("Favor de llenar todos los datos para los detalles");
        //            });
        //        return false;
        //    };
        //}
        $.ajax({
            type: 'POST',
            url: '/AjaxOperaciones/AgregarPago',
            data: JSON.stringify({ fechaPago: $('#Pago_FechaPago').val(), formaPago: $('#Pago_FormaPago').val(), moneda: $('#Pago_Moneda').val(), tipoCambio: $('#Pago_TipoCambio').val(), monto: $('#Pago_Monto').val(), numeroOperacion: $('#Pago_NumeroOperacion').val(), tipoCadenaPago: $('#Pago_TipoCadenaPago').val(), certificadoPago: $('#Pago_CertificadoPago').val(), cadenaPago: $('#Pago_CadenaPago').val(), selloPago: $('#Pago_SelloPago').val(), spei: null, bancoEmisorId: $('#Pago_BancoOrdenanteId').val(), bancoReceptorId: $('#Pago_BancoBeneficiarioId').val() }),
            dataType: 'html',
            contentType: "application/json; charset=utf-8",
            success: function (partialView) {
                $('#detalles').append(partialView);
            },
            error: function (jqxhr, textStatus, error) {
                alert("Favor de llenar todos los datos para los detalles");
            }
          });
        return false;
    });
});

function agregarFactura() {
    $.ajax({
        type: 'POST',
        url: '/AjaxOperaciones/AgregarFacturaComplementoPago',
        data: JSON.stringify({ pagoId: $('#PagoId').val(), facturaEmitidaId: $('#FacturaEmitidaId').val(), numeroParcialidad: $('#Pago_DocumentoRelacionado_NumeroParcialidad').val(), moneda: $('#Pago_DocumentoRelacionado_Moneda').val(), tipoCambio: $('#Pago_DocumentoRelacionado_TipoCambio').val(), importeSaldoAnterior: $('#Pago_DocumentoRelacionado_ImporteSaldoAnterior').val(), importePagado: $('#Pago_DocumentoRelacionado_ImportePagado').val(), importeSaldoInsoluto: $('#Pago_DocumentoRelacionado_ImporteSaldoInsoluto').val() }),
        dataType: 'html',
        contentType: "application/json; charset=utf-8",
        success: function (partialView) {
            $('#documento' + $('#PagoId').val()).append(partialView);
        },
        error: function (jqxhr, textStatus, error) {
            alert("Favor de seleccionar una factura");
        }
       });
    return false;
}

$(function () {
    $('#ReceptorId').on('change', function () {
        var bancoSeleccionado = $('#Pago_BancoOrdenanteId');
        var cfdisCancelados = $('#CfdiRelacionadoId');

        var receptorSeleccionado = $(this);

        bancoSeleccionado.empty();
        cfdisCancelados.empty();
        //bancoSeleccionado.prop('disabled', '');


        bancoSeleccionado.append($('<option>', {
            text: "Sin seleccionar",
            value: null
        }));

        //cfdisCancelados.append($('<option>', {
        //    text: "Favor de hacer su selección",
        //    value: null
        //}));

        if (receptorSeleccionado.val().length > 0 && receptorSeleccionado.val() !== 0) {
            $.ajax({
                type: 'POST',
                url: '/AjaxCatalogos/GetBancosClientes',
                data: JSON.stringify({ clienteId: receptorSeleccionado.val() }),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    $.each(data, function (i, banco) {
                        bancoSeleccionado.append($('<option>', {
                            value: banco.Id,
                            text: banco.Nombre
                        }));
                    });
                    //$('select').selectpicker('refresh');
                    return false;
                }
            });


            $.ajax({
                type: 'POST',
                url: '/AjaxCatalogos/GetCfdisCancelados',
                data: JSON.stringify({ clienteId: receptorSeleccionado.val() }),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (data2) {
                    $.each(data2, function (i, cfdi) {
                        cfdisCancelados.append($('<option>', {
                            value: cfdi.FacturaEmitida.Id,
                            text: cfdi.FacturaEmitida.Desplegado
                        }));
                    });
                    //$('select').selectpicker('refresh');
                    return false;
                }
            });
        }
    });
});

//JavaScript
function getBase64(file) {
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
        console.log(reader.result);
    };
    reader.onerror = function (error) {
        console.log('Error: ', error);
    };
}