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

        IEjectutivoRepositorio ejecutivoReporitorio;

        public EjecutivosController()
        {
            ejecutivoReporitorio = new MEjecutivoRepositorio();
        }

        public ActionResult Index()
        {
            var ListadoEjecutivosBD = ejecutivoReporitorio.ListarEjecutivos();
            var EjecutivosMostrar = Mapper.Map<List<Models.Ejecutivos>>(ListadoEjecutivosBD);
            return View(EjecutivosMostrar);
        }

        public ActionResult Registrar()
        {
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
                ejecutivoReporitorio.InsertarEjecutivo(EjecutivoRegistrar);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }


    }
}