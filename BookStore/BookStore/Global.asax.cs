using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BookStore.Migrations;
using BookStore.Models;

namespace BookStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BooksStoreContext, Configuration>());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
