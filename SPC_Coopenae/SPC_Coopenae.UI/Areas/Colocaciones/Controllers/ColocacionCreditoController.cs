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
        IEjectutivoRepositorio _repositorioEjecutivo;

        public ColocacionCreditoController()
        {
            _repositorioColCred = new MColocacionCreditoRepositorio();
            _repositorioEjecutivo = new MEjecutivoRepositorio();
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
            return View();
        }


        [HttpPost]
        public ActionResult Registrar(Models.ColocacionCredito colCred)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var col = Mapper.Map<DATA.ColocacionCredito>(colCred);
                _repositorioColCred.InsertarColocacionCredito(col);
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
                _repositorioColCred.EliminarColocacionCredito(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

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
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                var ColCredBuscar = _repositorioColCred.BuscarColocacionCredito(id);
                var ColCredEditar = Mapper.Map<Models.ColocacionCredito>(ColCredBuscar);
                return View(ColCredEditar);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(ColocacionCredito colCred)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var ColCredEditar = Mapper.Map<DATA.ColocacionCredito>(colCred);
                _repositorioColCred.ActualizarColocacionCredito(ColCredEditar);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return RedirectToAction("Index");
            }
        }

    }
}