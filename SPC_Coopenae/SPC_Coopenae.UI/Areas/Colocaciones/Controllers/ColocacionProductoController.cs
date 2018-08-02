using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Controllers
{
    public class ColocacionProductoController : Controller
    {

        IColocacionProductoRepositorio _repositorioColProd;
        IProductosRepositorio _repositorioProductos;

        public ColocacionProductoController()
        {
            _repositorioColProd = new MColocacionProductoRepositorio();
            _repositorioProductos = new MProductosRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoColocacionessBD = _repositorioColProd.ListarColocacionesProducto();
                var ColocacionesMostrar = Mapper.Map<List<Models.ColocacionProducto>>(ListadoColocacionessBD);
                return View(ColocacionesMostrar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
            
        }

        public ActionResult Registrar()
        {
            ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProductos(), "IdProducto", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.ColocacionProducto colocacionP)
        {
            try
            {
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProductos(), "IdProducto", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ColocacionRegistrar = Mapper.Map<DATA.ColocacionProducto>(colocacionP);
                _repositorioColProd.InsertarColocacionProducto(ColocacionRegistrar);
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
                _repositorioColProd.EliminarColocacionProducto(id);
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
                var ColocacionBuscar = _repositorioColProd.BuscarColocacionProducto(id);
                var ColocacionDetallar = Mapper.Map<Models.ColocacionProducto>(ColocacionBuscar);
                return View(ColocacionDetallar);
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
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProductos(), "IdProducto", "Nombre");
                var ColocacionBuscar = _repositorioColProd.BuscarColocacionProducto(id);
                var ColocacionEditar = Mapper.Map<Models.ColocacionProducto>(ColocacionBuscar);
                return View(ColocacionEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.ColocacionProducto colocacionP)
        {
            try
            {
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProductos(), "IdProducto", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ColocacionEditarBD = Mapper.Map<DATA.ColocacionProducto>(colocacionP);
                _repositorioColProd.ActualizarColocacionProducto(ColocacionEditarBD);
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