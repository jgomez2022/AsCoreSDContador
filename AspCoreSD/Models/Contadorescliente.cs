using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreSD.Models
{
    public class Contadorescliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Contador")]
        public int IdContador { get; set; }
    }
}
