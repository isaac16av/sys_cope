﻿using AutoMapper;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Mantenimientos.Controllers
{
    public class TipoCreditoController : Controller
    {
        ITipoCreditoRepositorio _repositorioTipoCredito;

        public TipoCreditoController()
        {
            _repositorioTipoCredito = new MTipoCreditoRepositorio();
        }

        public ActionResult Index()
        {
            var TipoCreditosBD = _repositorioTipoCredito.ListarTipoCredito();
            var TipoCreditosMostrar = Mapper.Map<List<Models.TipoCredito>>(TipoCreditosBD);
            return View(TipoCreditosMostrar);
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Models.TipoCredito tipoCreditoP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var TipoCreditoRegistrar = Mapper.Map<DATA.TipoCredito>(tipoCreditoP);
                _repositorioTipoCredito.InsertarTipoCredito(TipoCreditoRegistrar);
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
                _repositorioTipoCredito.EliminarTipoCredito(id);
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
                var TipoCreditoBuscar = _repositorioTipoCredito.BuscarTipoCredito(id);
                var TipoCreditoMostrar = Mapper.Map<Models.TipoCredito>(TipoCreditoBuscar);
                return View(TipoCreditoMostrar);
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
                var TipoCreditoBuscar = _repositorioTipoCredito.BuscarTipoCredito(id);
                var TipoCreditoEditar = Mapper.Map<Models.TipoCredito>(TipoCreditoBuscar);
                return View(TipoCreditoEditar);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult Editar(Models.TipoCredito tipoCreditoP)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var TipoCreditoEditarBD = Mapper.Map<DATA.TipoCredito>(tipoCreditoP);
                _repositorioTipoCredito.ActualizarTipoCredito(TipoCreditoEditarBD);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }


    }
}