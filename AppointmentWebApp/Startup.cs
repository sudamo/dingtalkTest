using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppointmentWebApp.Startup))]
namespace AppointmentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
