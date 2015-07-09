using Owin;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using ApplicationLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;

namespace ApplicationLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
