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

        IEjectutivoRepositorio ejecutivoRep;

        public EjecutivosController()
        {
            ejecutivoRep = new MEjecutivoRepositorio();
        }

        public ActionResult Index()
        {
            var ListadoEjecutivosBD = ejecutivoRep.ListarEjecutivos();
            var EjecutivosMostrar = Mapper.Map<List<Models.Ejecutivos>>(ListadoEjecutivosBD);
            return View(EjecutivosMostrar);
        }
    }
}