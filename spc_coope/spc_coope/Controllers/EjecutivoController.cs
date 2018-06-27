using spc_coope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace spc_coope.Controllers
{
    public class EjecutivoController : Controller
    {
        // GET: Ejecutivo
        public ActionResult Index()
        {
            try
            {
                using (spcDB db = new spcDB())
                {
                    var listadoEjecutivos = db.Ejecutivos.ToList();
                    return View(listadoEjecutivos);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}