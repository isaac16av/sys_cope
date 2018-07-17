using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MColocacionProductoRepositorio : IColocacionProductoRepositorio
    {
        public void ActualizarColocacionProducto(ColocacionProducto colocacion)
        {
            using (var dbc = new ConexionBD())
            {
                var aActualizar = dbc.ColocacionProducto.Find(colocacion.IdColocacionProducto);
                aActualizar.Fecha = colocacion.Fecha;
                aActualizar.Cedula = colocacion.Cedula;
                aActualizar.Nombre = colocacion.Nombre;
                aActualizar.CentroTrabajo = colocacion.CentroTrabajo;
                aActualizar.Producto = colocacion.Producto;
                aActualizar.Ejecutivo = colocacion.Ejecutivo;

                dbc.SaveChanges();

            }
        }

        public ColocacionProducto BuscarColocacionProducto(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.ColocacionProducto.Find(id);
            }
        }

        public void EliminarColocacionProducto(int id)
        {
            using (var dbc = new ConexionBD())
            {
                ColocacionProducto colocacion = dbc.ColocacionProducto.Find(id);
                dbc.ColocacionProducto.Remove(colocacion);
                dbc.SaveChanges();
            }
        }

        public void InsertarColocacionProducto(ColocacionProducto colocacion)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.ColocacionProducto.Add(colocacion);
                dbc.SaveChanges();
            }
        }

        public List<ColocacionProducto> ListarColocacionesProducto()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.ColocacionProducto.ToList();
            }
        }

        public List<ColocacionProducto> ListarColocacionesProductoPorEjecutivo(int cedula)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.ColocacionProducto.Where(x => x.Cedula == cedula).ToList();
            }
        }
    }
}
