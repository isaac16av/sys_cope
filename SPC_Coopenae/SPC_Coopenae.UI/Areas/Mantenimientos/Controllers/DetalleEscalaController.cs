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
    public class DetalleEscalaController : Controller
    {
        IDetalleEscalaRepositorio _repositorioDetalleEscala;
        IEscalaRepositorio _repositorioEscala;

        public DetalleEscalaController()
        {
            _repositorioDetalleEscala = new MDetalleEscalaRepositorio();
            _repositorioEscala = new MEscalaRepositorio();
            
           
        }

        // GET: Mantenimientos/DetalleEscala
        public ActionResult Index(int id)
        {
            try
            {
                return View();
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error: " + ex.Message);
                return View();
            }
        }

        public ActionResult Detalles(int id)
        {
            try
            {
                var DetalleBuscar = _repositorioDetalleEscala.BuscarDetalleEscala(id);
                var DetalleDetallar = Mapper.Map<Models.DetalleEscala>(DetalleBuscar);
                return View(DetalleDetallar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error: " + ex.Message);
                return View();
            }
        }
    }
}