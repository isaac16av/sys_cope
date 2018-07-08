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
            });
        }
    }
}