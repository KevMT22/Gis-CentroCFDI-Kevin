﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.CatalogosCartaPorte
{
    [Table("c_claveprodserv")]
    public class ClaveProdServ
    {
        [Key]
        [StringLength(8)]
        public String c_ClaveUnidad { get; set; }
        public String Descripcion { get; set; }
        public string EstímuloFranjaFronteriza { get; set; }
        public String PalabrasSimilares { get; set; }


    }
}
