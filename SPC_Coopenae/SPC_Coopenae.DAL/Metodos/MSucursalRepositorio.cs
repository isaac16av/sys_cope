using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MSucursalRepositorio : ISucursalRepositorio
    {
        public void ActualizarSucursal(Sucursal sucursalP)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(sucursalP).State = EntityState.Modified;

                dbc.SaveChanges();
            }
        }

        public Sucursal BuscarSucursal(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Sucursal.Find(id);
            }
        }

        public void EliminarSucursal(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var aEliminar = dbc.Sucursal.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarSucursal(Sucursal sucursal)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Sucursal.Add(sucursal);
                dbc.SaveChanges();
            }
        }

        public List<Sucursal> ListarSucursal()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Sucursal.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
