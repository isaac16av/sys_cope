using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Controllers
{
    public class AfiliacionesController : Controller
    {
        IAfiliacionRepositorio _repositorioAfiliacion;
        IEjectutivoRepositorio _repositorioEjecutivo;
        IComisionAfiliacionRepositorio _repositorioComA;

        public AfiliacionesController()
        {
            _repositorioAfiliacion = new MAfiliacionRepositorio();
            _repositorioEjecutivo = new MEjecutivoRepositorio();
            _repositorioComA = new MComisionAfiliacionRepositorio();
        }

        public ActionResult Index()
        {
            var listadoAfiliacionesBD = _repositorioAfiliacion.ListarAfiliaciones();
            var afiliacionesMostrar = Mapper.Map<List<Models.Afiliaciones>>(listadoAfiliacionesBD);
            return View(afiliacionesMostrar);
        }

        public ActionResult Registrar()
        {
            ViewBag.listaEjecutivos = new SelectList(_repositorioAfiliacion.ListarAfiliaciones(), "Cedula", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.Afiliaciones a)
        {
            try
            {
                ViewBag.listaEjecutivos = new SelectList(_repositorioAfiliacion.ListarAfiliaciones(), "Cedula", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var AfiliacionRegistrar = Mapper.Map<DATA.Afiliaciones>(a);
                _repositorioAfiliacion.InsertarAfiliacion(AfiliacionRegistrar);
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
                _repositorioAfiliacion.BuscarAfiliacion(id);
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
                var AfiliacionBuscar = _repositorioAfiliacion.BuscarAfiliacion(id);
                var AfiliacionDetallar = Mapper.Map<Models.Afiliaciones>(AfiliacionBuscar);
                return View(AfiliacionDetallar);
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
                ViewBag.listaEjecutivos = new SelectList(_repositorioAfiliacion.ListarAfiliaciones(), "IdAfiliacion", "Nombre");
                var AfiliacionBuscar = _repositorioAfiliacion.BuscarAfiliacion(id);
                var AfiliacionEditar = Mapper.Map<Models.Afiliaciones>(AfiliacionBuscar);
                return View(AfiliacionEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }
        [HttpPost]
        public ActionResult Editar(Models.Afiliaciones a)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var afiliacionEditarBD = Mapper.Map<DATA.Afiliaciones>(a);
                _repositorioAfiliacion.ActualizarAfiliacion(afiliacionEditarBD);
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