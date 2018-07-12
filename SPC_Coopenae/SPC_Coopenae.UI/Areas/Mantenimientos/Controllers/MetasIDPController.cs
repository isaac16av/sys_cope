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
    public class MetasIDPController : Controller
    {

        IMetaRepositorio _repositorio;

        public MetasIDPController()
        {
            _repositorio = new MMetaRepositorio();
        }

        public ActionResult Index()
        {
            var metas = _repositorio.ListarMetasIDP();
            var metasMostrar = Mapper.Map<List<Models.MetasIDP>>(metas);
            return View(metasMostrar);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.MetasIDP metasP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var metaRegistrar = Mapper.Map<DATA.MetasIDP>(metasP);
                _repositorio.InsertarMeta(metaRegistrar);
                return RedirectToAction("Index");
            }

            catch (Exception)
            {
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
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

        }

        public ActionResult Detalles(int id)
        {
            try
            {
                var MetaBuscar = _repositorio.BuscarMeta(id);
                var MetaDetallar = Mapper.Map<Models.MetasIDP>(MetaBuscar);
                return View(MetaDetallar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Editar(int id)
        {
            try
            {
                var MetaBuscar = _repositorio.BuscarMeta(id);
                var MetaEditar = Mapper.Map<Models.MetasIDP>(MetaBuscar);
                return View(MetaEditar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.MetasIDP metaP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var MetaEditarBD = Mapper.Map<DATA.MetasIDP>(metaP);
                _repositorio.ActualizarMeta(MetaEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }


    }
}