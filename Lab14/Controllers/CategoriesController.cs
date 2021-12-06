using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace Lab14.Controllers
{
    public class CategoriesController : Controller
    {
        private northwndEntities _contexto;

        public northwndEntities Contexto
        {
            set
            {
                _contexto = value;
            }
            get 
            { 
                if(_contexto == null)
                    _contexto = new northwndEntities();
                return _contexto;
            }
        }
        // GET: Categories
        public ActionResult Index()
        {
            return View(Contexto.Categories.ToList());
        }

        //GET
        public ActionResult Details(int id)
        {
            var productosPorCategoria = from p in Contexto.Products
                                        orderby p.ProductName ascending
                                        where p.CategoryID == id
                                        select p;
            return View(productosPorCategoria.ToList());
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Create(Categories nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Categories.Add(nuevaCategoria);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }


        //GET
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Categories CategoriaEditar = Contexto.Categories.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (CategoriaEditar == null)
                return HttpNotFound();

            return View(CategoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(Categories CategoriaEditar)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(CategoriaEditar).State = EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEditar);
            }
            catch (Exception e)
            {
                throw e;
                return View();
            }
        }

        //GET
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            //Buscar por categoria a editar
            Categories CategoriaEliminar = Contexto.Categories.Find(id);

            //Si la entidad es NULO (categoria no existe)
            if (CategoriaEliminar== null)
                return HttpNotFound();

            return View(CategoriaEliminar);
        }

        //POST
        [HttpPost]
        public ActionResult Delete(int? id, Categories Categoria1)
        {
            try
            {
                Categories CategoriaEliminar = new Categories();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    //busca categoria a eliminar
                    CategoriaEliminar = Contexto.Categories.Find(id);

                    //Si no encuentra la categoria
                    if (CategoriaEliminar == null)
                        return HttpNotFound();

                    //Elimina la categoria
                    Contexto.Categories.Remove(CategoriaEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(CategoriaEliminar);
            }
            catch
            {
                return View();
            }
        }


    }
}