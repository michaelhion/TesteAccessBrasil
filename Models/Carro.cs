using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cars_Api.Models
{
    public class Carro
    {        
        [Required]
        public int? MarcaCodigo { get; set; }

        [Required]
        public Marca Nome { get; set; }

        [Required]
        [Key]
        public int CarCodigo { get; set; }

        [Required]
        public string Modelo { get; set; }
       
        [Required]
        public int Ano { get; set; }

        public string Cor { get; set; }
    }
}