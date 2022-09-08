using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreSD.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DisplayName("Direccion")]
        public string Direccion { get; set; }
    }
}
