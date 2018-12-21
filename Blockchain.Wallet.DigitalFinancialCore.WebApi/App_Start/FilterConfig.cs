using System.Web;
using System.Web.Mvc;

namespace Blockchain.Wallet.DigitalFinancialCore.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
