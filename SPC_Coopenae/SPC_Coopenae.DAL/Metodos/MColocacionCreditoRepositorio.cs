using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MColocacionCreditoRepositorio : IColocacionCreditoRepositorio
    {
        public void ActualizarColocacionCredito(ColocacionCredito colCred)
        {
            using (var dbc = new ConexionBD())
            {
                var aColCred = dbc.ColocacionCredito.Find(colCred);
                aColCred.FechaFormalizacion = colCred.FechaFormalizacion;
                aColCred.Cedula = colCred.Cedula;
                aColCred.CentroTrabajo = colCred.CentroTrabajo;
                aColCred.Sector = colCred.Sector;
                aColCred.FechaAfiliacion = colCred.FechaAfiliacion;
                aColCred.NumeroOperacion = colCred.NumeroOperacion;
                aColCred.Sucursal = colCred.Sucursal;
                aColCred.MontoDesembolsado = colCred.MontoDesembolsado;
                aColCred.PlazoMeses = colCred.PlazoMeses;
                aColCred.TipoCredito = colCred.TipoCredito;
                aColCred.Ejecutivo = colCred.Ejecutivo;

                dbc.SaveChanges();

            }
        }

        public ColocacionCredito BuscarColocacionCredito(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.ColocacionCredito.Find(id);
            }
        }

        public void EliminarColocacionCredito(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var eColCred = dbc.ColocacionCredito.Find(id);
                dbc.ColocacionCredito.Remove(eColCred);

                dbc.SaveChanges();
            }
        }

        public void InsertarColocacionCredito(ColocacionCredito colCred)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.ColocacionCredito.Add(colCred);

                dbc.SaveChanges();
            }
        }

        public List<ColocacionCredito> ListarColocacionCredito()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.ColocacionCredito.ToList();
            }
        }
    }
}
