using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ListaToDo.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using ListaToDo.ViewModels;
using ListaToDo.Helpers;


namespace TodoList.Controllers
{
    public class VistaController : Controller
    {


        public IActionResult Ver()
        {
            VistaViewModel viewModel = new VistaViewModel();
            return View("Crear", viewModel);
        }

        public IActionResult Editar(int id)
        {
            VistaViewModel viewModel = new VistaViewModel();
            viewModel.EditableItem = viewModel.Vis.FirstOrDefault(x => x.Id == id);
            return View("Crear", viewModel);
        }

        public IActionResult Borrar(int id)
        {
            using (var db = DbHelper.GetConnection())
            {
                Vista item = db.Get<Vista>(id);
                if (item != null)
                    db.Delete(item);
                return RedirectToAction("Ver");
            }
        }

        public IActionResult CrearModificar(VistaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                using (var db = DbHelper.GetConnection())
                {
                    if (viewModel.EditableItem.Id <= 0)
                    {
                        viewModel.EditableItem.FechaCreacion = DateTime.Now;
                        db.Insert<Vista>(viewModel.EditableItem);
                    }
                    else
                    {
                        Vista dbItem = db.Get<Vista>(viewModel.EditableItem.Id);
                        TryUpdateModelAsync<Vista>(dbItem, "EditableItem");
                        db.Update<Vista>(dbItem);
                    }
                }
                return RedirectToAction("Ver");
            }
            else
                return View("Crear", new VistaViewModel());
        }


    }
}