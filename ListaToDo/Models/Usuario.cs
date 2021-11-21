using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre de usuario")]
        [MinLength(2, ErrorMessage = "Tienes menos de dos caracteres en el nombre")]
        [MaxLength(200, ErrorMessage = "Tienes muchos caracteres en el nombre")]
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
