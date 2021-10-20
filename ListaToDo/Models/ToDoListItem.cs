using System;
using System.ComponentModel.DataAnnotations;

namespace ListaToDo.Models
{
    public class ToDoListItem
    {
         //  en esta clase se crea la abstracción del modelo en la base de  datos
        //  aqui se representan cada una de las tablas modeladas  en la bd
        //  se  validad de cierta manera, een especial los string
        public int Id { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El título es obligatorio ")]

        [StringLength(250, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 2)]

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

     [StringLength(20, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 1)]

        [Display(Name = "Prioridad")]
        public string Prioridad { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha vencimiento")]

        public DateTime Fecha { get; set; } = System.DateTime.Today; //  aqui establezco el valor predeterminado del campo de  fecha, dejandolo a la fecha actual del sistema

        public bool Completada { get; set; }
        // public string Nombre { get; set; }
        public int IdCategoria { get; set; } //   esta es la llave foranea correspondiente a la base de datos
    }
}