namespace WebApiModules
{
    using System.Web.Http;
    using System.Web.Mvc;

    using WebApiModules.App_Start;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}