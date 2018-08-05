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
    public class ProductoController : Controller
    {

        IProductoRepositorio _repositorioProducto;

        public ProductoController()
        {
            _repositorioProducto = new MProductoRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoProductosBD = _repositorioProducto.ListarProducto();
                var ProductosMostrar = Mapper.Map<List<Models.Producto>>(ListadoProductosBD);
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
        public ActionResult Registrar(Models.Producto productosP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ProductoRegistrar = Mapper.Map<DATA.Producto>(productosP);
                _repositorioProducto.InsertarProducto(ProductoRegistrar);
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
                _repositorioProducto.EliminarProducto(id);
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
                var ProductoBuscar = _repositorioProducto.BuscarProducto(id);
                var ProductoDetallar = Mapper.Map<Models.Producto>(ProductoBuscar);
                return View(ProductoDetallar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                var ProductoBuscar = _repositorioProducto.BuscarProducto(id);
                var ProductoEditar = Mapper.Map<Models.Producto>(ProductoBuscar);
                return View(ProductoEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.Producto productosP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ProductoEditarBD = Mapper.Map<DATA.Producto>(productosP);
                _repositorioProducto.ActualizarProducto(ProductoEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

    }
}