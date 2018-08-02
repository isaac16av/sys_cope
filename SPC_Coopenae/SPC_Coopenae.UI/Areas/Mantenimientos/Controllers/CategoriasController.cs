using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Controllers
{
    public class CategoriasController : Controller
    {
        ICategoriaRepositorio _repositorioCategoria;

        public CategoriasController()
        {
            _repositorioCategoria = new MCategoriaRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoCategoriasBD = _repositorioCategoria.ListarCategorias();
                var CategoriasMostrar = Mapper.Map<List<Models.Categorias>>(ListadoCategoriasBD);
                return View(CategoriasMostrar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
            
        }


        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.Categorias categoriaP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var CategoriaRegistrar = Mapper.Map<DATA.Categorias>(categoriaP);
                _repositorioCategoria.InsertarCategoria(CategoriaRegistrar);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        public ActionResult Eliminar(int id)
        {
            try
            {
                _repositorioCategoria.EliminarCategoria(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }

        }

        public ActionResult Detalles(int id)
        {
            try
            {
                var CategoriaBuscar = _repositorioCategoria.BuscarCategoria(id);
                var CategoriaDetallar = Mapper.Map<Models.Categorias>(CategoriaBuscar);
                return View(CategoriaDetallar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

    }
}