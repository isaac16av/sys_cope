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
    public class EjecutivosController : Controller
    {

        IEjectutivoRepositorio _repositorioEjecutivo;
        ISucursalRepositorio _repositorioSucursal;

        public EjecutivosController()
        {
            _repositorioEjecutivo = new MEjecutivoRepositorio();
            _repositorioSucursal = new MSucursalRepositorio();
        }

        public ActionResult Index()
        {
            var ListadoEjecutivosBD = _repositorioEjecutivo.ListarEjecutivos();
            var EjecutivosMostrar = Mapper.Map<List<Models.Ejecutivos>>(ListadoEjecutivosBD);
            return View(EjecutivosMostrar);
        }

        public ActionResult Registrar()
        {
            ViewBag.listaSucursales = new SelectList(_repositorioSucursal.ListarSucursal(), "IdSucursal", "NombreSucursal");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.Ejecutivos ejecutivoP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var EjecutivoRegistrar = Mapper.Map<DATA.Ejecutivos>(ejecutivoP);
                _repositorioEjecutivo.InsertarEjecutivo(EjecutivoRegistrar);
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
                _repositorioEjecutivo.EliminarEjecutivo(id);
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
                var EjecutivoBuscar = _repositorioEjecutivo.BuscarEjecutivo(id);
                var EjecutivoDetallar = Mapper.Map<Models.Ejecutivos>(EjecutivoBuscar);
                return View(EjecutivoDetallar);
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
                ViewBag.listaSucursales = new SelectList(_repositorioSucursal.ListarSucursal(), "IdSucursal", "NombreSucursal");
                var EjecutivoBuscar = _repositorioEjecutivo.BuscarEjecutivo(id);
                var EjecutivoEditar = Mapper.Map<Models.Ejecutivos>(EjecutivoBuscar);
                return View(EjecutivoEditar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.Ejecutivos ejecutivoP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var EjecutivoEditarBD = Mapper.Map<DATA.Ejecutivos>(ejecutivoP);
                _repositorioEjecutivo.ActualizarEjecutivo(EjecutivoEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

    }
}