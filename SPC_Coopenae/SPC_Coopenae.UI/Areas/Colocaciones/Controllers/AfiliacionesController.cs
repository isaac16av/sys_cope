using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Controllers
{
    public class AfiliacionesController : Controller
    {
        IAfiliacionRepositorio _repositorioAfiliacion;
        IComisionAfiliacionRepositorio _repositorioComision;

        public AfiliacionesController()
        {
            _repositorioAfiliacion = new MAfiliacionRepositorio();
            _repositorioComision = new MComisionAfiliacionRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var listadoAfiliacionesBD = _repositorioAfiliacion.ListarAfiliaciones();
                var afiliacionesMostrar = Mapper.Map<List<Models.Afiliaciones>>(listadoAfiliacionesBD);
                return View(afiliacionesMostrar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
            
        }

        public ActionResult Registrar()
        {
            ViewBag.listaComisiones = new SelectList(_repositorioComision.ListarComisionAfiliacion(), "IdComisionAfiliacion", "Comision");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.Afiliaciones a)
        {
            try
            {
                ViewBag.listaComisiones = new SelectList(_repositorioComision.ListarComisionAfiliacion(), "IdComisionAfiliacion", "Comision");
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
                ViewBag.listaComisiones = new SelectList(_repositorioComision.ListarComisionAfiliacion(), "IdComisionAfiliacion", "Comision");
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
                ViewBag.listaComisiones = new SelectList(_repositorioComision.ListarComisionAfiliacion(), "IdComisionAfiliacion", "Comision");
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