using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using EtiketiUstunde.Data;
using EtiketiUstunde.Web.Models;

namespace EtiketiUstunde.Web.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var catalog = new EtiketiUstundeCatalog();

            var brickList = new List<BrickModel>();

            foreach (var product in catalog.Products)
            {
                var brick = new BrickModel();
                Mapper.Map(product, brick);
                brickList.Add(brick);
            }

            return View(new HomeModel
            {
                Bricks = brickList
            });
        }
    }
}
