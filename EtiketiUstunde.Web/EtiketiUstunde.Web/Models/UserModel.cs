using System.Globalization;

namespace EtiketiUstunde.Web.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName 
        {
            get { return string.Format(CultureInfo.InvariantCulture, "{0} {1}", FirstName, LastName); }
        }
    }
}