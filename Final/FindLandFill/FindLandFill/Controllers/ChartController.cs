using FindLandFill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindLandFill.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PieChart()
        {
            WasteEntities entities = new WasteEntities();
            return Json(entities.Wastes.ToList(), JsonRequestBehavior.AllowGet);
        }


    }
}