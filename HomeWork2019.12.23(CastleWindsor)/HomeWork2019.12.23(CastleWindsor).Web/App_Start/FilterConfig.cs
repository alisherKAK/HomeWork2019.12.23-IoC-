using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._23_CastleWindsor_.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
