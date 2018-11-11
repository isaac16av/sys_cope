using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC_Coopenae.BLL.Metas;
using SPC_Coopenae.DATA;
using SPC_Coopenae.DATA.ObjReportes;

namespace SPC_Coopenae.BLL.Reportes
{
    public class ReporteGeneral
    {

        #region Atributos
        private int cedula;
        public DateTime fecha { get;  }
        #endregion

        #region ObjetosExternos
        //Objeto al que segun los parametros que le lleguen sacara el IDP correspondiente
        CalculaIDP _calculaIDP;

        //Objeto que irá al IDP para verificar el idp correspondiente
        ReporteCreditos _reporteCreditos;
        ReporteProductos _reporteProductos;

        //Objeto que bucara la escala correspondiente y dira cuanto porcentaje comisiona
        ReporteEscala _reporteEscala;

        TipoCambioReporte _reporteTipoCambio;
        #endregion

        /// <summary>
        /// Constructor, se inicializan los objetos necesarios
        /// </summary>
        public ReporteGeneral(int cedulaP, DateTime fechaP)
        {
            //Asignar variables a la clase
            this.cedula = cedulaP;
            this.fecha = fechaP;
            //Instanciacion de otras clases
            _calculaIDP = new CalculaIDP();
            _reporteCreditos = new ReporteCreditos();
            _reporteProductos = new ReporteProductos();
            _reporteEscala = new ReporteEscala();
            _reporteTipoCambio = new TipoCambioReporte();
        }

        #region Metodos
        //Metodo engargado de hacer llamar a los demas metodos para el reporte
        public void IniciarReporte()
        {
            EstablecerTipoCambio();
            EstablecerMetas();
            SumarVentas();
            FijarIDPs();
            CompararConEscala();
            AsignarComisiones();
        }

        public void EstablecerTipoCambio()
        {
            _reporteTipoCambio.TraeTipoCambio(this.fecha);
        }

        //Asigna las metas correspondientes, segun la cedula de las clase
        private void EstablecerMetas()
        {
            _reporteCreditos.EstablecerMetaCorrespondiente(this.cedula);
            _reporteProductos.EstablecerMetaCorrespondiente(this.cedula);
        }

        //Suma de las ventas segun fecha y cedula
        private void SumarVentas()
        {
            _reporteCreditos.SumarMontosColocadosIDP(this.cedula, this.fecha);
            _reporteProductos.TraerCantidadPorMeta(this.fecha);
        }

        private void FijarIDPs()
        {
            _calculaIDP.metaCred = _reporteCreditos.metaCreditoCorrespondinte;
            _calculaIDP.FijarIDPCred(_reporteCreditos.SumaColocaciones);

            _calculaIDP.metaTipoProducto = _reporteProductos.metaTipoProductosCorrespondiente;
            _calculaIDP.FijarIDPProductos(_reporteProductos.metaYCantidadParaIDP);

            _calculaIDP.SumarIDps();
        }

        private void CompararConEscala()
        {
            _reporteEscala.EstablecerEscalaCorrespondiente(cedula);
            _reporteEscala.EstablecerPCTComisionSegunIDP(_calculaIDP.TotalIDP);
        }

        private void AsignarComisiones()
        {
            _reporteCreditos.AsignarComisionesTipoCreditos(this.cedula, this.fecha, _reporteEscala.PCTComision);
            _reporteProductos.AsignarComisionesProductos(this.cedula, this.fecha, _calculaIDP.TotalIDP, _reporteTipoCambio.tipoCambio.Valor);
        }

        #endregion

        #region Gets
        public List<RTipoCreditos> GetReporteTipoCreditos()
        {
            return _reporteCreditos.ComisionesPorTipoCreditos;
        }

        public List<RProductos> GetReporteProductos()
        {
            return _reporteProductos.ComisionesPorProductos;
        }

        public decimal GetTipoCambio()
        {
            return _reporteTipoCambio.tipoCambio.Valor;
        }
        #endregion

    }
}
