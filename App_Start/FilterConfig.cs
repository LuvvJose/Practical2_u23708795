﻿using System.Web;
using System.Web.Mvc;

namespace Practical2_u23708795
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
