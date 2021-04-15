using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cars_Api.Models
{
    public class Marca
    {
        [Required]
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Nome { get; set; }

        public virtual ICollection<Carro> Carros { get; set; }
    }
}