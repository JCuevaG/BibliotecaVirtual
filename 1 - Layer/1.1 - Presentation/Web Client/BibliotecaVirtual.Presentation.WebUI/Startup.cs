using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibliotecaVirtual.Presentation.WebUI.Startup))]
namespace BibliotecaVirtual.Presentation.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
