using Dapper.Contrib.Extensions;
using ListaToDo.Helpers;
using ListaToDo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaToDo.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ListaToDo.Controllers
{
    public class TareasController : Controller
    {
        private DatabaseContext _databaseContext;

        public TareasController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }




        //  Get
        public IActionResult Index()
        {

            var CategoriasList = (from categoria in _databaseContext.Categorias
                                  select new SelectListItem()
                                  {
                                      Text = categoria.Nombre,
                                      Value = categoria.Id.ToString()
                                  }).ToList();
            //CategoriasList.Insert(0, new SelectListItem()
            //{
            //    Text = "--- Seleccione un elemento ---",
            //    Value = string.Empty
            //});
            ViewBag.ListOfProduct = CategoriasList;

            TareasViewModel viewModel = new TareasViewModel();
            return View("Index", viewModel);
        }

        [HttpPost]
        public IActionResult Index(CategoriaViewModel categoriaViewModel)
        {
            var selectedValue = categoriaViewModel.EditableItem.Id;
            return View(categoriaViewModel);
        }

        public IActionResult Editar(int id)
        {
            TareasViewModel viewModel = new TareasViewModel();
            viewModel.EditableItem = viewModel.TodoItems.FirstOrDefault(x => x.Id == id);
            return View("Index", viewModel);
        }

        public IActionResult Borrar(int id)
        {
            using (var db = DbHelper.GetConnection())
            {
                ToDoListItem item = db.Get<ToDoListItem>(id); //   esto se hace usando dapper
                if (item != null)
                    db.Delete(item);
                return RedirectToAction("Index");
            }
        }

    //  Post
        public IActionResult CrearActualizar(TareasViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // try
                // {


                    using (var db = DbHelper.GetConnection())
                    {
                        if (viewModel.EditableItem.Id <= 0)
                        {
                            viewModel.EditableItem.FechaCreacion = DateTime.Now; //  para darle el valor de la fecha actual al momento de registrar a fecha actual                        
                            db.Insert<ToDoListItem>(viewModel.EditableItem);
                        }
                        else
                        {
                            ToDoListItem dbItem = db.Get<ToDoListItem>(viewModel.EditableItem.Id);
                            TryUpdateModelAsync<ToDoListItem>(dbItem, "EditableItem");
                            db.Update<ToDoListItem>(dbItem);
                        }
                    }
                    TempData["mensaje"] = "La tarea se ha creado correctamente";
                //}
                // catch (Exception)
                // {
                //     TempData["Error"] = "Ha ocurrido un error al guardar o actualizar la tarea";
                // }                 
                return RedirectToAction("Index");
            }
            else
                return View("Index", new TareasViewModel());
        }

        public IActionResult TareaCompletada(int id)
        {
            using (var db = DbHelper.GetConnection())
            {
                ToDoListItem item = db.Get<ToDoListItem>(id);
                if (item != null)
                {
                    item.Completada = !item.Completada;
                    db.Update<ToDoListItem>(item);
                }
                return RedirectToAction("Index");
            }
        }       



    }
}
