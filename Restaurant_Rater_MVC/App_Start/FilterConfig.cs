﻿using System.Web;
using System.Web.Mvc;

namespace Restaurant_Rater_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}