using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ja.Mvc.Acdf.Controllers
{
    public class AnecdoteController : Controller
    {
        // GET: Anecdote
        public ActionResult Index()
        {
            return View();
        }
    }
}