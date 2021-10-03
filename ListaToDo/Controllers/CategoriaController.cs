using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ListaToDo.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using ListaToDo.ViewModels;
using ListaToDo.Helpers;
using ListaToDo.Extensions;

namespace TodoList.Controllers
{
    public class CategoriaController : BaseController
    {
        CategoriaViewModel modeloCategoria = new CategoriaViewModel();

        public IActionResult Ver()
        {            
            
            CategoriaViewModel viewModel = new CategoriaViewModel();
            
            return View("Crear", viewModel);
        }

        public IActionResult Editar(int id)
        {
            CategoriaViewModel viewModel = new CategoriaViewModel();
            viewModel.EditableItem = viewModel.Cate.FirstOrDefault(x => x.Id == id);
            return View("Crear", viewModel);
        }

        public IActionResult Borrar(int id)
        {
            using (var db = DbHelper.GetConnection())
            {
                Categoria item = db.Get<Categoria>(id);
                if (item != null)
                    db.Delete(item);
                    TempData["mensaje"] = "Borrada con exito";
                return RedirectToAction("Ver");
                
            }
        }

        public IActionResult CrearModificar(CategoriaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                using (var db = DbHelper.GetConnection())
                {
                    if (viewModel.EditableItem.Id <= 0)
                    {
                        viewModel.EditableItem.FechaCreacion = DateTime.Now;                        
                        db.Insert<Categoria>(viewModel.EditableItem);
                    }
                    else
                    {
                        Categoria dbItem = db.Get<Categoria>(viewModel.EditableItem.Id);
                        TryUpdateModelAsync<Categoria>(dbItem, "EditableItem");
                        db.Update<Categoria>(dbItem);
                    }
                }
                TempData["mensaje"] = "Categoría creada con éxito";
                return RedirectToAction("Ver");
            }
            else
                return View("Crear", new CategoriaViewModel());
        }


    }
}