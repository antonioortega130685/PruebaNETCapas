using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public int id { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Los nombres sólo pueden contener letras y no números.")]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Los apellidos sólo pueden contener letras y no números.")]
        public string Apellido { get; set; }

        [Required]
        [Range(0,int.MaxValue, ErrorMessage = "Por favor intruzca un número de documento válido.")]
        public int DNI { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
