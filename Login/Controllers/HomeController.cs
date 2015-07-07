using System.Web.Mvc;
using Login.Models;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                Contact c = new Contact { ContactId = 2, name = "yoyo", age = 5 };
                context.Contacts.Add(c);
                context.SaveChanges();
            }
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
