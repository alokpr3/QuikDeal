using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QD_Project1._0.Controllers
{
    public class AdsController : Controller
    {
        // GET: Ads
        public ActionResult PostAd()
        {
            return View("PostAd");
        }
    }
}