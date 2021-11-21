using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.ViewModels
{
    public class EtiquetaViewModel
    {
        public EtiquetaViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new Etiqueta();
                this.Eti = db.Query<Etiqueta>("SELECT * FROM Etiquetas").ToList();
            }
        }

        public List<Etiqueta> Eti { get; set; }

        public Etiqueta EditableItem { get; set; }
    }
}
