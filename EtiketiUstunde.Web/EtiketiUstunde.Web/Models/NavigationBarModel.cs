using System.Collections.Generic;

namespace EtiketiUstunde.Web.Models
{
    public class NavigationBarModel
    {
        public IEnumerable<DivisionModel> Divisions { get; set; }

        public bool IsLoggedInUser { get; set; }

        public UserModel User { get; set; }
    }
}