﻿using API.Catalogos;
using API.CatalogosCartaPorte;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Operaciones.ComplementoCartaPorte
{
    [Table("cat_conceptos")]
    public class Cat_Conceptos
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Producto o servicio")]
        public string ClavesProdServ { get; set; }

        [DisplayName("Clave de producto o servicio")]
        public string ClaveProdServ_Id { get; set; }
        [ForeignKey("ClaveProdServ_Id")]
        public virtual ClaveProdServCP ClaveProdServCP { get; set; }

        
        public string ClavesUnidad { get; set; }
        [DisplayName("Clave de unidad")]
        public string ClaveUnidad_Id { get; set; }
        [ForeignKey("ClaveUnidad_Id")]
        public virtual ClaveUnidad ClaveUnidad { get; set; }  
        
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("No Identificación")]
        public string NoIdentificacion { get; set; }

        public string Cantidad { get; set; }
        [DisplayName("Valor Unitario")]
        public string ValorUnitario { get; set; }

        [DisplayName("Importe")]
        public Double Importe { get; set; }

        [DisplayName("Descuento")]
        public string Descuento { get; set; }

        [DisplayName("Sucursal")]
        public int SucursalId { get; set; }

        [ForeignKey("SucursalId")]
        public virtual Sucursal Sucursal { get; set; }

        [DisplayName("Objeto Impuesto")]
        public string ObjetoImpuesto { get; set; }

        [NotMapped]
        public string ObjetoImpuestoId { get; set; }
        
        [DisplayName("Impuesto Traslado")]
        public int? ImpuestoIdTras { get; set; }
        [ForeignKey("ImpuestoIdTras")]
        public virtual Cat_SubImpuestoC ImpuestoT { get; set; }
        
        [NotMapped]
        public int ImpuestoTID { get; set; }

        [DisplayName("Impuesto Retencion")]
        public int? ImpuestoIdRet { get; set; }
        [ForeignKey("ImpuestoIdRet")]
        public virtual Cat_SubImpuestoC ImpuestoR { get; set; }

        [NotMapped]
        public int ImpuestoRID { get; set; }
        [NotMapped]
        public virtual Cat_SubImpuestoC Traslado { get; set; }

        [NotMapped]
        public virtual SubImpuestoC Retencion { get; set; }
    }
}
