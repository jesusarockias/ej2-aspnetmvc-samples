﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Tooltip
{
    public partial class TooltipController : Controller
    {
        public ActionResult Menu()
        {
            List<ToolbarItem> popupItems = new List<ToolbarItem>();
            popupItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Wireless", Text = "Wireless & networks", Overflow = OverflowOption.Hide });
            popupItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Device", Text = "Device", Overflow = OverflowOption.Hide });
            popupItems.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Personal", Text = "Personal", Overflow = OverflowOption.Hide });
            ViewBag.popupItems = popupItems;
            return View();
        }
    }

}