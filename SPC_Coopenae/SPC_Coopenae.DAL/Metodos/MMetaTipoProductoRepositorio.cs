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
    public class MMetaTipoProductoRepositorio : IMetaTipoProductoRepositorio
    {
        public void ActualizarMetaTipoProducto(MetaTipoProducto metaTP)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Entry(metaTP).State = EntityState.Modified;
                dbc.SaveChanges();
            }
        }

        public MetaTipoProducto BuscarMetaTipoProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.MetaTipoProducto.Find(id);
            }
        }

        public void EliminarMetaTipoProducto(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var eMetaTP = dbc.MetaTipoProducto.Find(id);
                dbc.MetaTipoProducto.Remove(eMetaTP);
                dbc.SaveChanges();
            }
        }

        public void InsertarMetaTipoProducto(MetaTipoProducto metaTP)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaTipoProducto.Add(metaTP);
                dbc.SaveChanges();
            }
        }

        public List<MetaTipoProducto> ListarMetaTipoProducto()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.MetaTipoProducto.ToList();
            }
        }
    }
}
