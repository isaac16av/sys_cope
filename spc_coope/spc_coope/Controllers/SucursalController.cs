using spc_coope.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace spc_coope.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            try
            {
                using (var db = new spcDB())
                {
                    var listadoSucursales = db.Sucursal.ToList();
                    return View(listadoSucursales);
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
                    var sucursalBuscar = db.Sucursal.Find(id);
                    return View(sucursalBuscar);
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
        public ActionResult Create(Sucursal sucursal)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (var db = new spcDB())
                {
                    db.Sucursal.Add(sucursal);
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
                    Sucursal sucursalBuscar = db.Sucursal.Find(id);
                    return View(sucursalBuscar);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult Edit(
            [Bind(Include = "Idsucursal,Provincia,Canton,Descripcion,Categoria")]
            Sucursal sucursalEditada)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                using (var db = new spcDB())
                {

                    db.Entry(sucursalEditada).State = EntityState.Modified;
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