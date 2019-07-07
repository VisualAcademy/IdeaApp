using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdeaApp.WebForms.Startup))]
namespace IdeaApp.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
