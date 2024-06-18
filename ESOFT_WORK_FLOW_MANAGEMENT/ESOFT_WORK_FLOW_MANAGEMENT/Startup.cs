using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESOFT_WORK_FLOW_MANAGEMENT.Startup))]
namespace ESOFT_WORK_FLOW_MANAGEMENT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
