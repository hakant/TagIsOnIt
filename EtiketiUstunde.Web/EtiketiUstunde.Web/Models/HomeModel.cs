using System.Collections.Generic;


namespace EtiketiUstunde.Web.Models
{
    public class HomeModel
    {
        public bool IsLoggedInUser { get; set; }

        public IEnumerable<BrickModel> Bricks { get; set; }
    }
}