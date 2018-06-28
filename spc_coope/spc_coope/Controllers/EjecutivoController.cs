using spc_coope.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                using (var db = new spcDB())
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

        public ActionResult Details(int id)
        {
            try
            {
                using (var db = new spcDB())
                {
                    var ejecutivoBuscar = db.Ejecutivos.Find(id);
                    return View(ejecutivoBuscar);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Ejecutivos ejecutivo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (var db = new spcDB())
                {
                    db.Ejecutivos.Add(ejecutivo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
               
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                using (var db = new spcDB())
                {
                    Ejecutivos ejevutivoBuscar = db.Ejecutivos.Find(id);
                    return View(ejevutivoBuscar);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult Edit(
            [Bind(Include = "Cedula,Nombre,Apellidos,Sexo,Telefono,Correo,CodigoVendedor,Residencia,Sucursal,FechaNacimiento,FechaContratacion")]
            Ejecutivos ejecutivoEditado)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (var db = new spcDB())
                {

                        db.Entry(ejecutivoEditado).State = EntityState.Modified;
                        db.SaveChanges();
                     

                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}