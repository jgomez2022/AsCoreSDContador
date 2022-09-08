using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreSD.Models
{
    public class Lecturacontador
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [DisplayName("Numero de contador")]
        public string Contador { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Lectura")]
        public int Lectura { get; set; }
        [DisplayName("Fecha")]
        public DateTime Fecha { get; set; }
    }
}
