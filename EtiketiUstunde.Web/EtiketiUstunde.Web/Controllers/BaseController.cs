using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using EtiketiUstunde.Data;
using EtiketiUstunde.Web.Models;

namespace EtiketiUstunde.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.NavigationBarModel = CreateNavigationBarModel();
        }

        protected virtual NavigationBarModel CreateNavigationBarModel()
        {
            var catalog = new EtiketiUstundeCatalog();

            var brickList = new List<BrickModel>();
            var divisionList = new List<DivisionModel>();

            foreach (var division in catalog.Divisions)
            {
                var divisionModel = new DivisionModel();
                Mapper.Map(division, divisionModel);
                divisionList.Add(divisionModel);
            }

            return new NavigationBarModel()
                {
                    Divisions = divisionList
                };
        }
    }
}
