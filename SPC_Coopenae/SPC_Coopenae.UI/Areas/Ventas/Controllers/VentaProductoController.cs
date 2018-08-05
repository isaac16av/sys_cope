using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Ventas.Controllers
{
    public class VentaProductoController : Controller
    {

        IVentaProductoRepositorio _repositorioVentaProducto;
        IProductoRepositorio _repositorioProductos;

        public VentaProductoController()
        {
            _repositorioVentaProducto = new MVentaProductoRepositorio();
            _repositorioProductos = new MProductoRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoVentasBD = _repositorioVentaProducto.ListarVentasProducto();
                var VentasMostrar = Mapper.Map<List<Models.VentaProducto>>(ListadoVentasBD);
                return View(VentasMostrar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
            
        }

        public ActionResult Registrar()
        {
            ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProducto(), "IdProducto", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.VentaProducto ventaP)
        {
            try
            {
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProducto(), "IdProducto", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var VentaRegistrar = Mapper.Map<DATA.VentaProducto>(ventaP);
                _repositorioVentaProducto.InsertarVentaProducto(VentaRegistrar);
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
                _repositorioVentaProducto.EliminarVentaProducto(id);
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
                var VentaBuscar = _repositorioVentaProducto.BuscarVentaProducto(id);
                var VentaDetallar = Mapper.Map<Models.VentaProducto>(VentaBuscar);
                return View(VentaDetallar);
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
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProducto(), "IdProducto", "Nombre");
                var VentaBuscar = _repositorioVentaProducto.BuscarVentaProducto(id);
                var VentaEditar = Mapper.Map<Models.VentaProducto>(VentaBuscar);
                return View(VentaEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.VentaProducto ventaP)
        {
            try
            {
                ViewBag.listaProductos = new SelectList(_repositorioProductos.ListarProducto(), "IdProducto", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var VentaEditarBD = Mapper.Map<DATA.VentaProducto>(ventaP);
                _repositorioVentaProducto.ActualizarVentaProducto(VentaEditarBD);
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