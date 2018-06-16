using System.Web;
using System.Web.Mvc;

namespace TroyCampbell_Blackjack
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
