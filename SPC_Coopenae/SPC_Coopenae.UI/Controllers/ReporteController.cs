using AutoMapper;
using SPC_Coopenae.BLL.Reportes;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.UI.Models;
using SPC_Coopenae.UI.Models.ObjsReporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Controllers
{
    public class ReporteController : Controller
    {

        ReporteGeneral _reporteBLL;
        IEjectutivoRepositorio _repositorioEjecutivo;

        public ReporteController()
        {
            _repositorioEjecutivo = new MEjecutivoRepositorio();
        }


        public ActionResult Index()
        {
            if (TempData["MensajeError"] != null)
            {
                ViewBag.MensajeError = TempData["MensajeError"].ToString();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? cedula)
        {
            try
            {
                if (cedula != null)
                {
                    var EjecutivoReportar = _repositorioEjecutivo.BuscarEjecutivo(cedula.Value);
                    if (EjecutivoReportar == null)
                    {
                        ViewBag.MensajeError = "La cédula " + cedula + " no pertenece a ningún ejecutivo";
                        return View();
                    }
                    return RedirectToAction("EjecutivoMensual", new { id = cedula });
                }
                else
                {
                    ViewBag.MensajeError = "Error. Debe ingresar la cédula del ejecutivo.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.MensajeError = "Ocurrió un error. " + ex.Message;
                return View();
            }
        }

        public ActionResult EjecutivoMensual(int? id)
        {
            ViewBag.MensajeError = null;
            if (id != null)
            {
                try
                {
                    int cedula = id.Value;
                    var EjecutivoReportar = _repositorioEjecutivo.BuscarEjecutivo(cedula);

                    ViewBag.CedulaEjecutivo = EjecutivoReportar.Cedula;
                    ViewBag.NombreEjecutivo = EjecutivoReportar.Nombre + " " + EjecutivoReportar.Apellidos;

                    _reporteBLL = new ReporteGeneral(cedula, DateTime.Now);
                    _reporteBLL.IniciarReporte();
                    ViewBag.FechaReporte = "Para el mes de " + _reporteBLL.fecha.ToString("MMM") + " del " + _reporteBLL.fecha.Year;

                    Reporte reporteMostrar = new Reporte();
                    var reporteTipoCreditosBLL = _reporteBLL.GetReporteTipoCreditos();
                    reporteMostrar.listaTipoCreditos = Mapper.Map<List<ReporteTipoCreditos>>(reporteTipoCreditosBLL);
                    reporteMostrar.TotalComisionesGeneradas = reporteMostrar.listaTipoCreditos.Sum(x => x.TotalComision ?? 0);

                    return View(reporteMostrar);
                }
                catch (Exception ex)
                {
                    ViewBag.MensajeError = "Ocurrió un error. " + ex.Message;
                    return View();
                }
            }
            else
            {
                TempData["MensajeError"] = "Error. Debe ingresar la cédula del ejecutivo.";
                return RedirectToAction("Index");
            }

        }

    }
}