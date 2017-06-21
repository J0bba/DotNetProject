using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeditateBook.Startup))]
namespace MeditateBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
