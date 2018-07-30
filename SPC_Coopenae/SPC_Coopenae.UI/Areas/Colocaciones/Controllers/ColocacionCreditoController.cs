using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.DATA;

namespace SPC_Coopenae.UI.Areas.Colocaciones.Controllers
{
    public class ColocacionCreditoController : Controller
    {

        IColocacionCreditoRepositorio _repositorioColCred;
        ITipoCreditoRepositorio _repositorioTipoCred;

        public ColocacionCreditoController()
        {
            _repositorioColCred = new MColocacionCreditoRepositorio();
            _repositorioTipoCred = new MTipoCreditoRepositorio();
        }

        // GET: Mantenimientos/ColocacionCredito
        public ActionResult Index()
        {
            var listarColCred = _repositorioColCred.ListarColocacionCredito();
            var ColCredListado = Mapper.Map<List<Models.ColocacionCredito>>(listarColCred);
            return View(ColCredListado);
        }

        public ActionResult Registrar()
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCred.ListarTipoCredito(), "IdCredito", "NombreDeCredito");
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }

        }


        [HttpPost]
        public ActionResult Registrar(Models.ColocacionCredito colCred)
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCred.ListarTipoCredito(), "IdCredito", "NombreDeCredito");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var col = Mapper.Map<DATA.ColocacionCredito>(colCred);
                _repositorioColCred.InsertarColocacionCredito(col);
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
                _repositorioColCred.EliminarColocacionCredito(id);
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
                var colCredBuscar = _repositorioColCred.BuscarColocacionCredito(id);
                var colCredDetallar = Mapper.Map<Models.ColocacionCredito>(colCredBuscar);
                return View(colCredDetallar);
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
                ViewBag.listaTipos = new SelectList(_repositorioTipoCred.ListarTipoCredito(), "IdCredito", "NombreDeCredito");
                var ColCredBuscar = _repositorioColCred.BuscarColocacionCredito(id);
                var ColCredEditar = Mapper.Map<Models.ColocacionCredito>(ColCredBuscar);
                return View(ColCredEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Ocurrió un error", ex);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(ColocacionCredito colCred)
        {
            try
            {
                ViewBag.listaTipos = new SelectList(_repositorioTipoCred.ListarTipoCredito(), "IdCredito", "NombreDeCredito");
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ColCredEditar = Mapper.Map<DATA.ColocacionCredito>(colCred);
                _repositorioColCred.ActualizarColocacionCredito(ColCredEditar);
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