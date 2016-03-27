using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NotificationApp.Startup))]
namespace NotificationApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}