using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MSucursalRepositorio : ISucursalRepositorio
    {
        public void ActualizarSucursal(Sucursal sucursalP)
        {
            using (var dbc = new ConexionBD())
            {
                var sActualizar = dbc.Sucursal.Find(sucursalP.IdSucursal);
                sActualizar.NombreSucursal = sucursalP.NombreSucursal;
                sActualizar.Categoria = sucursalP.Categoria;

                dbc.SaveChanges();
            }
        }

        public Sucursal BuscarSucursal(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Sucursal.Find(id);
            }
        }

        public void EliminarSucursal(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var aEliminar = dbc.Sucursal.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarSucursal(Sucursal sucursal)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Sucursal.Add(sucursal);
                dbc.SaveChanges();
            }
        }

        public List<Sucursal> ListarSucursal()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.Sucursal.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
