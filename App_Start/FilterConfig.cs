﻿using System.Web;
using System.Web.Mvc;

namespace Wolff_MIS4200_1045
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
