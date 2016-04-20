using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SessionTest.Controllers
{
    [OutputCache(NoStore = true,Duration = 0)]      //不缓存数据
    public class HomeController : Controller
    {
        public List<string> boxes = new List<string>() { "red", "green", "blue", "black", "gray", "yellow", "orange" }; 

        public ActionResult Index()
        {
            return View();
        }

        public string GetBox()
        {
            Thread.Sleep(10);
            Random rnd = new Random();
            int index = rnd.Next(0, boxes.Count);

            return boxes[index];
        }

        public ActionResult StartSeesion()      //启用Session并存值
        {
            Session["Name"] = "Chris";
            return RedirectToAction("Index");
        }
    }
}