using System.Web;
using System.Web.Mvc;

namespace POOII_CL3_Rodríguez_León_Mitchell
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
