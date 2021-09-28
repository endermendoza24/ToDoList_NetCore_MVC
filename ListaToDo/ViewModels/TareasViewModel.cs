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
                this.TodoItems = db.Query<ToDoListItem>("SELECT * FROM ToDoListItems ORDER BY Fecha ASC").ToList();
            }
        }

        public List<ToDoListItem> TodoItems { get; set; }

        public ToDoListItem EditableItem { get; set; }
    }
}