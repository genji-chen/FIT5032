using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assessment.Startup))]
namespace assessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
