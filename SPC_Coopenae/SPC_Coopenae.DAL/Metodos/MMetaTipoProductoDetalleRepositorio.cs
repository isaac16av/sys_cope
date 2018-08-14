using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MMetaTipoProductoDetalleRepositorio : IMetaTipoProductoDetalleRepositorio
    {
        public void InsertarMetaTipoProductoDetalle(MetaTipoProductoDetalle mtpd)
        {
            using (var dbc = new SPC_BD())
            {
                dbc.MetaTipoProductoDetalle.Add(mtpd);
                dbc.SaveChanges();
            }
        }

        public List<MetaTipoProductoDetalle> ListarMetaTipoProductoDetalle()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.MetaTipoProductoDetalle.ToList();
            }
        }
    }
}
