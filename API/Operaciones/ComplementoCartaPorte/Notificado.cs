﻿using API.CatalogosCartaPorte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using API.Enums;

namespace API.Operaciones.ComplementoCartaPorte
{
    [Table("cp_notificado")]
    public class Notificado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Nombre del Notificado")]
        public String NombreNotificado { get; set; }

        [DisplayName("Número de Identificación o Registro Fiscal del Notificado")]
        public String NumRegIdTribNotificado { get; set; }

        [DisplayName("Residencia Fiscal del Notificado")]
        public c_Pais ResidenciaFiscalNotificado { get; set; }

        [NotMapped]
        [DisplayName("País")]
        public String Pais { get; set; }

        [DisplayName("RFC del Notificado")]
        public String RFCNotificado { get; set; }

        public int Domicilio_Id { get; set; }
        [ForeignKey("Domicilio_Id")]
        public virtual Domicilio Domicilio { get; set; }

    }
}
