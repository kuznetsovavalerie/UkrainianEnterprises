using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UkrainianEnterprises.Startup))]
namespace UkrainianEnterprises
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
