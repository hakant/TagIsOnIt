using System.Collections.Generic;

namespace EtiketiUstunde.Web.Models
{
    public class NavigationBarModel
    {
        public bool IsLoggedInUser { get; set; }

        public IEnumerable<DivisionModel> Divisions { get; set; }

    }
}