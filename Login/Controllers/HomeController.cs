using System.Web.Mvc;
using ApplicationLayer.Models;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                context.Contacts.Add(new Contact {Name = "ssds"});
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
