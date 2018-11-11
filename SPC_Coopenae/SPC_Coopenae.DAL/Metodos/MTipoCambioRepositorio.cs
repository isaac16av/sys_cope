using SPC_Coopenae.DAL.Interfaces;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos
{
    public class MTipoCambioRepositorio : ITipoCambioRepositorio
    {

        public TipoCambio BuscarTipoCambioFecha(DateTime fechaP)
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.TipoCambio.Where(x => (x.Fecha.Month == fechaP.Month &&
                                                  x.Fecha.Year == fechaP.Year &&
                                                  x.Estado == true)).First();
            }
        }

        public List<TipoCambio> ListarTipoCambio()
        {
            using (var dbc = new SPC_BD())
            {
                return dbc.TipoCambio.ToList();
            }
        }
    }
}
