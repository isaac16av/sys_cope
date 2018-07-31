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
    public class SucursalController : Controller
    {

        ISucursalRepositorio _repositorio;

        public SucursalController()
        {
            _repositorio = new MSucursalRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListadoSucusalesBD = _repositorio.ListarSucursal();
                var SucursalesMostrar = Mapper.Map<List<Models.Sucursal>>(ListadoSucusalesBD);
                return View(SucursalesMostrar);
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
        public ActionResult Registrar(Models.Sucursal sucursalP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var SucursalRegistrar = Mapper.Map<DATA.Sucursal>(sucursalP);
                _repositorio.InsertarSucursal(SucursalRegistrar);
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
                _repositorio.EliminarSucursal(id);
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
                var SucursalBuscar = _repositorio.BuscarSucursal(id);
                var SucursalDetallar = Mapper.Map<Models.Sucursal>(SucursalBuscar);
                return View(SucursalDetallar);
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
                var SucursalBuscar = _repositorio.BuscarSucursal(id);
                var SucursalEditar = Mapper.Map<Models.Sucursal>(SucursalBuscar);
                return View(SucursalEditar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.Sucursal sucursalP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var SucursalEditarBD = Mapper.Map<DATA.Sucursal>(sucursalP);
                _repositorio.ActualizarSucursal(SucursalEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

    }
}