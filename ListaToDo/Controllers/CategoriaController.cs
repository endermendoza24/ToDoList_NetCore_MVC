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
        CategoriaViewModel modeloCategoria = new CategoriaViewModel(); //   instancia de la clase de  modelo categoria

        public IActionResult Ver() //   este  es un método get, muestra la información recuperada de la base de datos
        {            
            
            CategoriaViewModel viewModel = new CategoriaViewModel(); //  instancia de la clase de view modelo--> categoria
  
            return View("Crear", viewModel);
        }

        //  metodo post
        public IActionResult Editar(int id)
        {
            CategoriaViewModel viewModel = new CategoriaViewModel();
            viewModel.EditableItem = viewModel.Cate.FirstOrDefault(x => x.Id == id);
            //  aqui se utiliza un metodo de LinQ llamado FirstOrDefault
            // este metodo devuelve el primer elemento de una secuencia, en este caso de la fuente de datos
            //  del  viewModel de categoria
            return View("Crear", viewModel);
        }

       

        public IActionResult Borrar(int id)
        {
            using (var db = DbHelper.GetConnection())
            {
                Categoria item = db.Get<Categoria>(id); //  aqui se obtiene el id de la lista que deseamos eliminar
                if (item != null)
                    db.Delete(item); //  si no resulta nulo, usando dapper procedemos al borrado del elemento en cuestion
                    TempData["mensaje"] = "Borrada con exito"; //  con esto mandamos un mensaje de exito al usuario a través de un tempData
                return RedirectToAction("Ver");
                
            }
        }


        //  este es el metodo más importante,   desde aca como el nombre lo indica se crea y se actualizan los 
        //  registros
        public IActionResult CrearModificar(CategoriaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                
                try
                {
                     using (var db = DbHelper.GetConnection()) //  se usa la conexión
                {
                    if (viewModel.EditableItem.Id <= 0)
                    {
                        viewModel.EditableItem.FechaCreacion = DateTime.Now; //   se inserta la fecha actual en el 
                        //  elemento de fechaDeCreacion para que el usuario no tenga necesidad de hacerlo                
                        db.Insert<Categoria>(viewModel.EditableItem); //  ocurre la acción de la inserción
                    }
                    else //  sino se deveulve a la vista
                    {
                        Categoria dbItem = db.Get<Categoria>(viewModel.EditableItem.Id);
                        TryUpdateModelAsync<Categoria>(dbItem, "EditableItem");
                        db.Update<Categoria>(dbItem);
                    }
                }
                TempData["mensaje"] = "Categoría creada con éxito"; // si todo es correcto, se enviaun mensaje de 
                //  satisfacción
                }
                catch (System.Exception)
                {
                    TempData["Error"] = "Ha ocurrido un error al guardar la categoría";

                    //  de no ser correcto se envia un mensaje de  error
                }
                return RedirectToAction("Ver");
            }
            else
                return View("Crear", new CategoriaViewModel());
        }


    }
}