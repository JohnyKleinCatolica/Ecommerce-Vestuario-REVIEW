using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ecommerce_Vestuario_REVIEW.Startup))]
namespace Ecommerce_Vestuario_REVIEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
