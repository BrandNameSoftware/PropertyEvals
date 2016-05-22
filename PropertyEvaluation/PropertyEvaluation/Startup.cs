using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropertyEvaluation.Startup))]
namespace PropertyEvaluation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
