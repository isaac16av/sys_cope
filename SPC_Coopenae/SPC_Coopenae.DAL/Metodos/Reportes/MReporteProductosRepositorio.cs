using SPC_Coopenae.DATA.ObjReportes;
using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL.Metodos.Reportes
{
    public class MReporteProductosRepositorio
    {

        public MetaTipoProducto BuscarMetaProducto(int cedulaP)
        {
            using (var dbc = new SPC_BD())
            {
                return (from ejecutivo in dbc.Ejecutivo
                        join unidad in dbc.UnidadNegocio on ejecutivo.UnidadNegocio equals unidad.IdUnidad
                        join meta in dbc.Meta on unidad.Meta equals meta.IdMeta
                        join metaTipoProd in dbc.MetaTipoProducto on meta.IdMeta equals metaTipoProd.Meta
                        where unidad.Estado == true &&
                              meta.Estado == true &&
                              ejecutivo.Cedula == cedulaP
                        select metaTipoProd).FirstOrDefault();
            }
        }

        public List<TipoProducto> ConsultaTiposProductos(int metaProd)
        {
            using (var dbc = new SPC_BD())
            {
                return (from metaTipProdDetalle in dbc.MetaTipoProductoDetalle
                        join tipoProducto in dbc.TipoProducto on metaTipProdDetalle.TipoProducto equals tipoProducto.IdTipoProducto
                        where metaTipProdDetalle.MetaTipoProducto == metaProd
                        select tipoProducto).ToList();
            }
        }


    }
}
