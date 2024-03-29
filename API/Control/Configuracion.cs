﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Control
{
    [Table("cfg_configuraciones")]
    public class Configuracion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String Concepto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String Valor { get; set; }

    }
}
