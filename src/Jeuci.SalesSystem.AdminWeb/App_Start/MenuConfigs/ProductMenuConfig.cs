﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abp.Application.Navigation;
using Abp.Localization;

namespace Jeuci.SalesSystem.AdminWeb
{
    public class ProductMenuConfig
    {
        public static MenuItemDefinition AddProductMenuItems()
        {
            return new MenuItemDefinition(
                "Product",
                 new LocalizableString("NavBar_Product", SalesSystemConsts.LocalizationSourceName),
                 url: "",
                 icon: "fa fa-cubes"
                 ).AddItem(new MenuItemDefinition(
                          "Brand",
                          new LocalizableString("NavBar_Brand", SalesSystemConsts.LocalizationSourceName),
                          icon: "fa fa-globe",
                          url: "Products/Brand/Index"
                     ))
                 ;
        }
    }
}