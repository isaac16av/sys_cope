using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPC_Coopenae
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UI.Areas.Mantenimientos.Models.Ejecutivos, DATA.Ejecutivos>();
                cfg.CreateMap<DATA.Ejecutivos, UI.Areas.Mantenimientos.Models.Ejecutivos>();

                cfg.CreateMap<UI.Areas.Mantenimientos.Models.Sucursal, DATA.Sucursal>();
                cfg.CreateMap<DATA.Sucursal, UI.Areas.Mantenimientos.Models.Sucursal>();

                cfg.CreateMap<UI.Areas.Mantenimientos.Models.MetasIDP, DATA.MetasIDP>();
                cfg.CreateMap<DATA.MetasIDP, UI.Areas.Mantenimientos.Models.MetasIDP>();
              
                cfg.CreateMap<UI.Areas.Mantenimientos.Models.Categorias, DATA.Categorias>();
                cfg.CreateMap<DATA.Categorias, UI.Areas.Mantenimientos.Models.Categorias>();

                cfg.CreateMap<UI.Areas.Colocaciones.Models.ColocacionCredito, DATA.ColocacionCredito>();
                cfg.CreateMap<DATA.ColocacionCredito, UI.Areas.Colocaciones.Models.ColocacionCredito>();
              
                cfg.CreateMap<UI.Areas.Colocaciones.Models.ColocacionProducto, DATA.ColocacionProducto>();
                cfg.CreateMap<DATA.ColocacionProducto, UI.Areas.Colocaciones.Models.ColocacionProducto>();

                cfg.CreateMap<UI.Areas.Mantenimientos.Models.Productos, DATA.Productos>();
                cfg.CreateMap<DATA.Productos, UI.Areas.Mantenimientos.Models.Productos>();
                
                cfg.CreateMap<UI.Areas.Mantenimientos.Models.TipoCredito, DATA.TipoCredito>();
                cfg.CreateMap<DATA.TipoCredito, UI.Areas.Mantenimientos.Models.TipoCredito>();

            });
        }
    }
}