using System.Web;
using System.Web.Mvc;

namespace TantumCms
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}
