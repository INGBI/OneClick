﻿using System.Web;
using System.Web.Mvc;

namespace oneCLICK_Dummy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}