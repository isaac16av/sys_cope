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
    public class MTipoCreditoRepositorio : ITipoCreditoRepositorio
    {
        public void ActualizarTipoCredito(TipoCredito tipoCredito)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.Entry(tipoCredito).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public TipoCredito BuscarTipoCredito(int id)
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.TipoCredito.Find(id);
            }
        }

        public void EliminarTipoCredito(int id)
        {
            using (var dbc = new ConexionBD())
            {
                var aEliminar = dbc.TipoCredito.Find(id);
                aEliminar.Estado = 0;
                dbc.SaveChanges();
            }
        }

        public void InsertarTipoCredito(TipoCredito tipoCredito)
        {
            using (var dbc = new ConexionBD())
            {
                dbc.TipoCredito.Add(tipoCredito);
                dbc.SaveChanges();
            }
        }

        public List<TipoCredito> ListarTipoCredito()
        {
            using (var dbc = new ConexionBD())
            {
                return dbc.TipoCredito.Where(x => x.Estado == 1).ToList();
            }
        }
    }
}
