using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.Models
{
    public class Etiqueta
    {
        //  en esta clase se crea la abstracción del modelo en la base de  datos
        //  aqui se representan cada una de las tablas modeladas  en la bd
        //  se  validad de cierta manera, een especial los string
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre de la etiqueta")]
        [MinLength(2, ErrorMessage = "Tienes menos de dos caracteres en el nombre")]
        [MaxLength(200, ErrorMessage = "Tienes muchos caracteres en el nombre")]
        public string NombreEtiqueta { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
