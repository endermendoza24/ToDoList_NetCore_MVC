using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.Models
{
    public class Vista
    {
        [Key]
        public int Id { get; set; }
        public bool Completada { get; set; }

        [Required(ErrorMessage = "El título es obligatorio ")]

        [StringLength(200, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 2)]

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public int Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Nombre { get; set; }
    }
}
