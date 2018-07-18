using System.Web.Mvc;

namespace SPC_Coopenae.UI.Areas.Colocaciones
{
    public class ColocacionesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Colocaciones";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Colocaciones_default",
                "Colocaciones/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}