using System.Web.Mvc;

namespace ApplicationLayer.Areas.Account
{
    public class AccountAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Account";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
        "Account_default",
        "Account/{controller}/{action}/{id}",
        new { controller = "Home", action = "Index", id = UrlParameter.Optional },
        new string[] { "Login.Areas.Account.Contollers" }
            );
        }
    }
}

