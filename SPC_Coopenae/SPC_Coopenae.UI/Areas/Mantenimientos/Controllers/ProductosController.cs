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
    public class ProductosController : Controller
    {

        IProductosRepositorio _repositorioProductos;

        public ProductosController()
        {
            _repositorioProductos = new MProductosRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoProductosBD = _repositorioProductos.ListarProductos();
                var ProductosMostrar = Mapper.Map<List<Models.Productos>>(ListadoProductosBD);
                return View(ProductosMostrar);
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
        public ActionResult Registrar(Models.Productos productosP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ProductoRegistrar = Mapper.Map<DATA.Productos>(productosP);
                _repositorioProductos.InsertarProductos(ProductoRegistrar);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult Eliminar(int id)
        {
            try
            {
                _repositorioProductos.EliminarProductos(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

        }

        public ActionResult Detalles(int id)
        {
            try
            {
                var ProductoBuscar = _repositorioProductos.BuscarProductos(id);
                var ProductoDetallar = Mapper.Map<Models.Productos>(ProductoBuscar);
                return View(ProductoDetallar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                var ProductoBuscar = _repositorioProductos.BuscarProductos(id);
                var ProductoEditar = Mapper.Map<Models.Productos>(ProductoBuscar);
                return View(ProductoEditar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.Productos productosP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ProductoEditarBD = Mapper.Map<DATA.Productos>(productosP);
                _repositorioProductos.ActualizarProductos(ProductoEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

    }
}