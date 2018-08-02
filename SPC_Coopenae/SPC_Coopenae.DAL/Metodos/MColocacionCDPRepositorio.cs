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
    public class MColocacionCDPRepositorio : IColocacionCDPRepositorio
    {
        public void ActualizarCDP(ColocacionCDP cdp)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(cdp).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public ColocacionCDP BuscarCDP(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionCDP.Find(id);
;           }
        }

        public void EliminarCDP(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var aBorrar = dbc.ColocacionCDP.Find(id);
                dbc.ColocacionCDP.Remove(aBorrar);
                dbc.SaveChanges();
            }
        }

        public void InsertarCDP(ColocacionCDP cdp)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.ColocacionCDP.Add(cdp);
                dbc.SaveChanges();
            }
        }

        public List<ColocacionCDP> ListarCDP()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.ColocacionCDP.ToList();
            }
        }
    }
}
