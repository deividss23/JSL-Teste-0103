﻿using System.Web;
using System.Web.Mvc;

namespace JSL_Teste_0103
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
