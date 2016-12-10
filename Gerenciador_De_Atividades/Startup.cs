using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gerenciador_De_Atividades.Startup))]
namespace Gerenciador_De_Atividades
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
