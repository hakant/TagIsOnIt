using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using EtiketiUstunde.Data;
using EtiketiUstunde.Data.Infrastructure;
using EtiketiUstunde.Data.Model;
using EtiketiUstunde.Web.App_Start;
using EtiketiUstunde.Web.Models;

namespace EtiketiUstunde.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AuthConfig.RegisterAuth();

            InitializeMappers();
            Bootstrap.InitializeDatabase();
        }

        private static void InitializeMappers()
        {
            Mapper.CreateMap<Product, BrickModel>();
            Mapper.CreateMap<Category, CategoryModel>();
            Mapper.CreateMap<Division, DivisionModel>();
            Mapper.CreateMap<CategoryGroup, CategoryGroupModel>();
        }
    }
}