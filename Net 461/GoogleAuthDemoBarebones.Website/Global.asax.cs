﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GoogleAuthDemoBarebones.Website
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}