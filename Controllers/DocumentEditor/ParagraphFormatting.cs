﻿using Syncfusion.EJ2.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.DocumentEditor
{
    public partial class DocumentEditorController : Controller
    {
        public ActionResult ParagraphFormatting()
        {
            return View();
        }

        public ActionResult ParagraphFormat()
        {
            return this.DocumentEditorViewResultHelper();
        }
    }
}