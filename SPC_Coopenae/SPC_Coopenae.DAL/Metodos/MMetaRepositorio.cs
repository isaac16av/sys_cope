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
    public class MMetaRepositorio : IMetaRepositorio
    {

        public int InsertarMeta(Meta meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.Meta.Add(meta);
                dbc.SaveChanges();

                return meta.IdMeta;
            }
        }

        public void EliminarMeta(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var metaEliminar = dbc.Meta.Find(id);
                metaEliminar.Estado = false;
                dbc.SaveChanges();
            }
        }

        public Meta BuscarMeta(int id)
        {
            using (var dbc = new SPC_BD())
            {
                var metaB = dbc.Meta.Find(id);
                return metaB;
            }
        }

        public void InsertarMetaCredito(MetaCredito meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaCredito.Add(meta);
                dbc.SaveChanges();
            }
        }

        public void InsertarMetaCDP(MetaCDP meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaCDP.Add(meta);
                dbc.SaveChanges();
            }
        }

        public List<Meta> ListarMetas()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.Meta.Where(x => x.Estado == true).ToList();
            }
        }

        public int InsertarMetaProducto(MetaTipoProducto meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaTipoProducto.Add(meta);
                dbc.SaveChanges();

                return meta.IdMetaTipoProducto;
            }
        }

        public void InsertarMetaProductoDetalle(MetaTipoProductoDetalle meta)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaTipoProductoDetalle.Add(meta);
                dbc.SaveChanges();
            }
        }

    }
}
