using Ja.Mvc.Acdf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ja.Mvc.Acdf.Controllers
{
    public class TrampController : Controller
    {
        // GET: Tramp
        public ActionResult Index()
        {
            string trampsPath = Server.MapPath("~/Medias/LogosTramp");
            var DI = new System.IO.DirectoryInfo(trampsPath);
            System.IO.FileInfo[] fiArr = DI.GetFiles();
            var model = from f in fiArr
                        orderby f.Name
                        select new TrampViewModel()
                        {
                            FilePath = System.IO.Path.Combine(HttpRuntime.AppDomainAppVirtualPath, @"Medias/LogosTramp", f.Name),
                            MetaData = f.Name.Split('_', '.')[1]
                        };
            return View(model);
        }

    }
}