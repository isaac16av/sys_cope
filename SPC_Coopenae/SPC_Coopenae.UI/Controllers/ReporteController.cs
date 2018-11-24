using AutoMapper;
using SPC_Coopenae.BLL.Reportes;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using SPC_Coopenae.UI.Models;
using SPC_Coopenae.UI.Models.ObjsReporte;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(int cedula, string fecha)
        {
            return RedirectToAction("Mensual", new { id = cedula, fecha = fecha });
        }

        public ActionResult Mensual(int? id, string fecha)
        {
            try
            {
                if (id != null && fecha != null)
                {
                    int cedula = id.Value;
                    var EjecutivoReportar = _repositorioEjecutivo.BuscarEjecutivo(cedula);

                    if (EjecutivoReportar == null)
                    {
                        TempData["MensajeError"] = "No se encontró la cédula " + cedula;
                        return RedirectToAction("Index");
                    }

                    DateTime FechaReporte = Convert.ToDateTime(fecha);

                    Reporte reporteMostrar = GenerarReporte(cedula, FechaReporte);
                    reporteMostrar.Cedula = EjecutivoReportar.Cedula;
                    reporteMostrar.Nombre = EjecutivoReportar.Nombre + " " + EjecutivoReportar.Apellidos;
                    reporteMostrar.Fecha = FechaReporte;

                    return View(reporteMostrar);
                }
                else
                {
                    TempData["MensajeError"] = "Debe ingresar los datos que se solicitan.";
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                TempData["MensajeError"] = "Ocurrió un error. " + ex.Message;
                return RedirectToAction("Index");
            }

        }

        [NonAction]
        public bool ValidarEjecutivo(int cedula)
        {
            var EjecutivoReportar = _repositorioEjecutivo.BuscarEjecutivo(cedula);
            if (EjecutivoReportar == null)
            {
                return false;
            }
            return true;
        }

        [NonAction]
        private Reporte GenerarReporte(int cedulaReporte, DateTime fechaReporte)
        {
            _reporteBLL = new ReporteGeneral(cedulaReporte, fechaReporte);
            _reporteBLL.IniciarReporte();

            Reporte reporteVista = new Reporte();

            reporteVista.TipoCambio = _reporteBLL.GetTipoCambio();

            var reporteTipoCreditosBLL = _reporteBLL.GetReporteTipoCreditos();
            reporteVista.listaTipoCreditos = Mapper.Map<List<RTipoCreditos>>(reporteTipoCreditosBLL);
            reporteVista.TotalComisionCreditos = reporteVista.listaTipoCreditos.Sum(x => x.TotalComision);

            var reporteProductos = _reporteBLL.GetReporteProductos();
            reporteVista.listaProductos = Mapper.Map<List<RProductos>>(reporteProductos);
            reporteVista.TotalComisionProductos = reporteVista.listaProductos.Sum(x => x.TotalComision);

            reporteVista.TotalComisionesGanadas = reporteVista.TotalComisionCreditos.Value + reporteVista.TotalComisionProductos;

            return reporteVista;
        }




    }
}