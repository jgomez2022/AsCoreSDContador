using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreSD.Models
{
    public class Contador
    {
     

    

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Numero de contador")]
        public string Numerocontador { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Tipo")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Aplica tarifa social")]
        public string Aplica_ts { get; set; }
    }
}
