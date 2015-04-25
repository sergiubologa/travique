using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicJournal.Startup))]
namespace PublicJournal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
