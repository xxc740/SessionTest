using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SessionTest.Controllers
{
    [OutputCache(NoStore = true,Duration = 0)]
    public class SessionResolvedController : Controller
    {
        public List<string> boxes = new List<string>() { "red", "green", "blue", "black", "gray", "yellow", "orange" };

        public string GetBox()
        {
            try
            {
                Thread.Sleep(10);
                Random rnd = new Random();
                int index = rnd.Next(0, boxes.Count);

                return boxes[index];
            }
            catch (Exception e)
            {
                return "red";
            }
        }
    }
}