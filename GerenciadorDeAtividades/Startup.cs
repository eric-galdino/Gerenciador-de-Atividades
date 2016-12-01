using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GerenciadorDeAtividades.Startup))]
namespace GerenciadorDeAtividades
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
