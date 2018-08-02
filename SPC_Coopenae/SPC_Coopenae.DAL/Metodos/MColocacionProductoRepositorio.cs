﻿using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MColocacionProductoRepositorio : IColocacionProductoRepositorio
    {
        public void ActualizarColocacionProducto(ColocacionProducto colocacion)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(colocacion).State = EntityState.Modified;

                dbc.SaveChanges();

            }
        }

        public ColocacionProducto BuscarColocacionProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionProducto.Find(id);
            }
        }

        public void EliminarColocacionProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                ColocacionProducto colocacion = dbc.ColocacionProducto.Find(id);
                dbc.ColocacionProducto.Remove(colocacion);
                dbc.SaveChanges();
            }
        }

        public void InsertarColocacionProducto(ColocacionProducto colocacion)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.ColocacionProducto.Add(colocacion);
                dbc.SaveChanges();
            }
        }

        public List<ColocacionProducto> ListarColocacionesProducto()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionProducto.ToList();
            }
        }

    }
}
