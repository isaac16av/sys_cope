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
    public class EscalaController : Controller
    {
        IEscalaRepositorio _repositorio;
        IDetalleEscalaRepositorio _repositorioDetalleE;

        public EscalaController()
        {
            _repositorio = new MEscalaRepositorio();
            _repositorioDetalleE = new MDetalleEscalaRepositorio();
        }

        // GET: Mantenimientos/Escala
        public ActionResult Index()
        {
            try
            {
                var listadoEscala = _repositorio.ListarEscalas();
                var escalaMostrar = Mapper.Map<List<Models.Escala>>(listadoEscala);
                return View(escalaMostrar);

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
        public ActionResult Registrar(Models.Escala esc)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                DetalleEscala detalle = null;

                var escalaRegistrar = Mapper.Map<DATA.Escala>(esc);
                
                int id = _repositorio.InsertarEscala(escalaRegistrar);


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
                _repositorio.EliminarEscala(id);
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
                var EscalaBuscar = _repositorio.BuscarEscala(id);
                var EscalaDetallar = Mapper.Map<Models.Escala>(EscalaBuscar);
                return View(EscalaDetallar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        
    }
}