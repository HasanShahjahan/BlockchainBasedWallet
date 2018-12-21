using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Blockchain.Wallet.DigitalFinancialCore.WebApi.Startup))]

namespace Blockchain.Wallet.DigitalFinancialCore.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
