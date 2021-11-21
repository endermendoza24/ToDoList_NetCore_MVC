using Dapper;
using ListaToDo.Helpers;
using ListaToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaToDo.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                this.EditableItem = new Usuario();
                this.Usu = db.Query<Usuario>("SELECT * FROM Usuarios").ToList();
            }
        }

        public List<Usuario> Usu { get; set; }

        public Usuario EditableItem { get; set; }
    }
}
