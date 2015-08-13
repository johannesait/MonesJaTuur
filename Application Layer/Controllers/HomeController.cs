using ApplicationLayer.Areas.Account.Models;
using DataLayer;
using System.Web.Mvc;

namespace ApplicationLayer.Controllers
{
    [HandleError()]
    public class HomeController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Account" });
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
