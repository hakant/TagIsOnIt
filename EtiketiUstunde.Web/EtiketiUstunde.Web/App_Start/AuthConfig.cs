using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;

namespace EtiketiUstunde.Web.App_Start
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "nyFWkDzXFRwocqnMS2E3Cg",
                consumerSecret: "QCrjxGl3qWKwoQlf0PboaHixaGPyQjiej2PHSonLndI");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "325713500860151",
                appSecret: "5a088c0c9a0039011c4a24e81e83fc11");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
