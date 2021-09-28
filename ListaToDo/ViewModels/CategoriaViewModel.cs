using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.ViewModels
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new Categoria();
                this.Cate = db.Query<Categoria>("SELECT * FROM Categorias").ToList();
            }
        }

        public List<Categoria> Cate { get; set; }

        public Categoria EditableItem { get; set; }
    }
}
