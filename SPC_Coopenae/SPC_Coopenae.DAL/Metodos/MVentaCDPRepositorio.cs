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
    public class MVentaCDPRepositorio : IVentaCDPRepositorio
    {
        public void ActualizarCDP(VentaCDP cdp)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(cdp).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public VentaCDP BuscarCDP(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaCDP.Find(id);
;           }
        }

        public void EliminarCDP(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var aBorrar = dbc.VentaCDP.Find(id);
                dbc.VentaCDP.Remove(aBorrar);
                dbc.SaveChanges();
            }
        }

        public void InsertarCDP(VentaCDP cdp)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.VentaCDP.Add(cdp);
                dbc.SaveChanges();
            }
        }

        public List<VentaCDP> ListarCDP()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.VentaCDP.ToList();
            }
        }

        public List<VentaCDP> BuscarListarCDP(int ejecutivo, DateTime fecha)
        {
            using (var dbc = new SPC_BD())
            {
                return (from ventaCDP in dbc.VentaCDP
                        where ventaCDP.Ejecutivo == ejecutivo &&
                        ventaCDP.Fecha.Month == fecha.Month &&
                        ventaCDP.Fecha.Year == fecha.Year
                        select ventaCDP).ToList();
            }
        }
    }
}
