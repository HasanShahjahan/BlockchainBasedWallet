using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlockchainBasedWalletSystem.WebClient.Startup))]
namespace BlockchainBasedWalletSystem.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
