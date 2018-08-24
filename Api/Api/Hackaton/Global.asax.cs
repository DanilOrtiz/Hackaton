using Hackaton.Infraestructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Hackaton
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<HackatonUnitOfWork>(new DropCreateDatabaseIfModelChanges<HackatonUnitOfWork>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            

        }
    }
}
