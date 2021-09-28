using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.ViewModels
{
    public class VistaViewModel
    {
        public VistaViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new Vista();
                this.Vis = db.Query<Vista>("SELECT        dbo.TodoListItems.Id, dbo.TodoListItems.Completada, dbo.TodoListItems.Titulo, dbo.TodoListItems.Fecha, dbo.TodoListItems.Prioridad, dbo.TodoListItems.FechaCreacion, dbo.Categorias.Nombre FROM            dbo.Categorias INNER JOIN dbo.TodoListItems ON dbo.Categorias.Id = dbo.TodoListItems.IdCategoria").ToList();
            }
        }

        public List<Vista> Vis { get; set; }

        public Vista EditableItem { get; set; }
    }
}
