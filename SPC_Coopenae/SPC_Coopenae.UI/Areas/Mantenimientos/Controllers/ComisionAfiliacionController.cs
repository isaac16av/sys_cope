using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.DATA;
using SPC_Coopenae.UI.Areas.Mantenimientos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Controllers
{
    public class ComisionAfiliacionController : Controller
    {
        IComisionAfiliacionRepositorio _repositorioComA;

        public ComisionAfiliacionController()
        {
            _repositorioComA = new MComisionAfiliacionRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var listadoComisionAfiliacion = _repositorioComA.ListarComisionAfiliacion();
                var ComisionAfiliacionMostrar = Mapper.Map<List<Models.ComisionAfiliacion>>(listadoComisionAfiliacion);
                return View(ComisionAfiliacionMostrar);
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
        public ActionResult Registrar(Models.ComisionAfiliacion comA)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var comisionAfiliacionRegistrar = Mapper.Map<DATA.ComisionAfiliacion>(comA);
                _repositorioComA.InsertarComisionAfiliacion(comisionAfiliacionRegistrar);
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
                _repositorioComA.EliminarComisionAfiliacion(id);
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
                var comisionAfiliacionBuscar = _repositorioComA.BuscarComisionAfiliacion(id);
                var comisionAfiliacionDetallar = Mapper.Map<Models.ComisionAfiliacion>(comisionAfiliacionBuscar);
                return View(comisionAfiliacionDetallar);
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
                var comisionAfiliacionBuscar = _repositorioComA.BuscarComisionAfiliacion(id);
                var comisionAfiliacionEditar = Mapper.Map<Models.ComisionAfiliacion>(comisionAfiliacionBuscar);
                return View(comisionAfiliacionEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }

        }

        [HttpPost]
        public ActionResult Editar(Models.ComisionAfiliacion comA)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var comisionAfiliacionEditarBD = Mapper.Map<DATA.ComisionAfiliacion>(comA);
                _repositorioComA.ActualizarComisionAfiliacion(comisionAfiliacionEditarBD);
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