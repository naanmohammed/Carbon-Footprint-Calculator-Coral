using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coral_Group_Project.Startup))]
namespace Coral_Group_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
