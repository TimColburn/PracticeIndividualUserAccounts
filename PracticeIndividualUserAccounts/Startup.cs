using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeIndividualUserAccounts.Startup))]
namespace PracticeIndividualUserAccounts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
