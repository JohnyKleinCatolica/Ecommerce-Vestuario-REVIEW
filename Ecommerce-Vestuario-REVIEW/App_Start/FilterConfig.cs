using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Vestuario_REVIEW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //Todos os controlers precisam autenticar
        }
    }
}
