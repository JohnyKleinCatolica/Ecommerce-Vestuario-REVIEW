using System.Web;
using System.Web.Mvc;

namespace Video_Locadora_ExemploMVC_REVIEW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
