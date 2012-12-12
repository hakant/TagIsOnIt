using System;
using System.Data.Entity;
using System.Threading;
using System.Web.Mvc;
using EtiketiUstunde.Data;
using WebMatrix.WebData;

namespace EtiketiUstunde.Web.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class InitializeSimpleMembershipAttribute : ActionFilterAttribute
    {
        private static SimpleMembershipInitializer _initializer;
        private static object _initializerLock = new object();
        private static bool _isInitialized;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Ensure ASP.NET Simple Membership is initialized only once per app start
            LazyInitializer.EnsureInitialized(ref _initializer, ref _isInitialized, ref _initializerLock);
        }

        private class SimpleMembershipInitializer
        {
            public SimpleMembershipInitializer()
            {
                WebSecurity.InitializeDatabaseConnection("EtiketiUstundeDbContext", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }
        }
    }
}
