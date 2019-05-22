using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizBox.Admin.Startup))]
namespace QuizBox.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
