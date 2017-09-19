using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace HappyMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            ViewBag.fileArray = files;

            return View();
        }

        public ActionResult Content(string id)
        {
            var pathName = Server.MapPath($"~/TextFiles/{id}.txt");
            ViewBag.content = System.IO.File.ReadAllText(pathName);

            return View();
        }
    }
}