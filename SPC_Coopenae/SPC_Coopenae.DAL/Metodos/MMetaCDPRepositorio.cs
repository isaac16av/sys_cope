using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System.Data.Entity;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MMetaCDPRepositorio : IMetaCDPRepositorio
    {
        public void ActualizarMetaCDP(MetaCDP metaCDP)
        {
            using (var dbc = new SPC_BD()) {
                dbc.Entry(metaCDP).State = EntityState.Modified;

                dbc.SaveChanges();
            }
        }

        public MetaCDP BuscarMetaCDP(int id)
        {
            using (var dbc = new SPC_BD()) {
                return dbc.MetaCDP.Find(id);
            }
        }

        public void EliminarMetaCDP(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarMetaCDP(MetaCDP metaCDP)
        {
            using (var dbc = new SPC_BD()) {
                dbc.MetaCDP.Add(metaCDP);
                dbc.SaveChanges();
            }
        }

        public List<MetaCDP> ListarMetaCDP()
        {
            using (var dbc = new SPC_BD()) {
                return dbc.MetaCDP.ToList();
            }
        }
    }
}
