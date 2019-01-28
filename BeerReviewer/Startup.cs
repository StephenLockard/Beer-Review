using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerReviewer.Startup))]
namespace BeerReviewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
