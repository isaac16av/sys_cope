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
    public class MetaController : Controller
    {

        IMetaRepositorio _repositorio;

        public MetaController()
        {
            _repositorio = new MMetaRepositorio();
        }

        public ActionResult Index()
        {
            try
            {
                var metas = _repositorio.ListarMetas();
                var metasMostrar = Mapper.Map<List<Models.Meta>>(metas);
                return View(metasMostrar);
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
        public ActionResult Registrar(Models.Meta metasP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var metaRegistrar = Mapper.Map<DATA.Meta>(metasP);
                _repositorio.InsertarMeta(metaRegistrar);
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
                _repositorio.EliminarMeta(id);
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
                var MetaBuscar = _repositorio.BuscarMeta(id);
                var MetaDetallar = Mapper.Map<Models.Meta>(MetaBuscar);
                return View(MetaDetallar);
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
                var MetaBuscar = _repositorio.BuscarMeta(id);
                var MetaEditar = Mapper.Map<Models.Meta>(MetaBuscar);
                return View(MetaEditar);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrió un error: " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.Meta metaP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var MetaEditarBD = Mapper.Map<DATA.Meta>(metaP);
                _repositorio.ActualizarMeta(MetaEditarBD);
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