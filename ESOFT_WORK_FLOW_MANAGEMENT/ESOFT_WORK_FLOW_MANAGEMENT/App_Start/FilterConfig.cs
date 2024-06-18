using System.Web;
using System.Web.Mvc;

namespace ESOFT_WORK_FLOW_MANAGEMENT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
