using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using EtiketiUstunde.Data;
using EtiketiUstunde.Web.Models;
using WebMatrix.WebData;

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

            var navigationBarModel = new NavigationBarModel()
                {
                    IsLoggedInUser = Request.IsAuthenticated,
                    Divisions = divisionList
                };

            if (Request.IsAuthenticated)
            {
                var currentUserId = (WebSecurity.GetUserId(User.Identity.Name));
                
                var currentUser = catalog.UserProfiles.FirstOrDefault(x => x.UserId == currentUserId);

                if (currentUser != null)
                {
                    navigationBarModel.User = new UserModel
                        {
                            UserName = currentUser.UserName,
                            FirstName = currentUser.FirstName,
                            LastName = currentUser.LastName
                        };
                }
            }

            return navigationBarModel;
        }
    }
}
