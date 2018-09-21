﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult Image()
        {
            object tools1 = new
            {
                tooltipText = "Rotate Left",
                template = "<button class='e-tbar-btn e-btn' id='roatateLeft'><span class='e-btn-icon e-icons e-rotate-left'></span>"
            };
            object tools2 = new
            {
                tooltipText = "Rotate Right",
                template = "<button class='e-tbar-btn e-btn' id='roatateRight'><span class='e-btn-icon e-icons e-rotate-right'></span>"
            };
            ViewBag.image = new[] {
                "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
                "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension",tools1
                , tools2
            };

            return View();
        }
    }
}
