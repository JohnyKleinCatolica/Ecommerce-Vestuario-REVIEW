using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video_Locadora_ExemploMVC_REVIEW.Startup))]
namespace Video_Locadora_ExemploMVC_REVIEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
