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
    public class ColocacionCDPController : Controller
    {

        IColocacionCDPRepositorio _repositorioCDP;
        ITipoCDPRepositorio _repositorioTipoCDP;

        public ColocacionCDPController()
        {
            _repositorioCDP = new MColocacionCDPRepositorio();
            _repositorioTipoCDP = new MTipoCDPRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var ListaCDPsBD = _repositorioCDP.ListarCDP();
                var ListaMostrarCDPs = Mapper.Map<List<Models.ColocacionCDP>>(ListaCDPsBD);
                return View(ListaMostrarCDPs);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        public ActionResult Registrar()
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCDP.ListarTipoCDP(), "IdTipoCDP", "Nombre");
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }

        }


        [HttpPost]
        public ActionResult Registrar(Models.ColocacionCDP colocacionCDP)
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCDP.ListarTipoCDP(), "IdTipoCDP", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var colocacion = Mapper.Map<DATA.ColocacionCDP>(colocacionCDP);
                _repositorioCDP.InsertarCDP(colocacion);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

        public ActionResult Eliminar(int id)
        {
            try
            {
                _repositorioCDP.EliminarCDP(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

        public ActionResult Detalles(int id)
        {
            try
            {
                var colCDPBuscar = _repositorioCDP.BuscarCDP(id);
                var colCDPDetallar = Mapper.Map<Models.ColocacionCDP>(colCDPBuscar);
                return View(colCDPDetallar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCDP.ListarTipoCDP(), "IdTipoCDP", "Nombre");
                var ColCDPBuscar = _repositorioCDP.BuscarCDP(id);
                var ColCDPEditar = Mapper.Map<Models.ColocacionCDP>(ColCDPBuscar);
                return View(ColCDPEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.ColocacionCDP colCDP)
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCDP.ListarTipoCDP(), "IdTipoCDP", "Nombre");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ColCDPEditar = Mapper.Map<DATA.ColocacionCDP>(colCDP);
                _repositorioCDP.ActualizarCDP(ColCDPEditar);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

    }
}