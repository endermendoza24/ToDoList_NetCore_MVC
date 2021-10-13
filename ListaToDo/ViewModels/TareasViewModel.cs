using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;

namespace ListaToDo.ViewModels
{
    public class TareasViewModel
    {
        public TareasViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new ToDoListItem();
              this.TodoItems = db.Query<ToDoListItem>("SELECT * FROM ToDoListItems ORDER BY Fecha ").ToList();
                // this.TodoItems = db.Query<ToDoListItem>("SELECT        dbo.TodoListItems.Id, dbo.TodoListItems.Completada, dbo.TodoListItems.Titulo, dbo.TodoListItems.Fecha, dbo.TodoListItems.Prioridad, dbo.TodoListItems.FechaCreacion, dbo.Categorias.Nombre FROM            dbo.Categorias INNER JOIN dbo.TodoListItems ON dbo.Categorias.Id = dbo.TodoListItems.IdCategoria").ToList();
            }
        }

        public List<ToDoListItem> TodoItems { get; set; }

        public ToDoListItem EditableItem { get; set; }
    }
}