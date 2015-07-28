using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ja.Mvc.Acdf.Models;

namespace Ja.Mvc.Acdf.Controllers
{
    public class CategoryController : Controller
    {
        private AcdfEntities db = new AcdfEntities();

        // GET: AcdfCategory
        public ActionResult Index()
        {
            return View(db.AcdfCategories.ToList());
        }

        // GET: AcdfCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfCategory acdfCategory = db.AcdfCategories.Find(id);
            if (acdfCategory == null)
            {
                return HttpNotFound();
            }
            return View(acdfCategory);
        }

        // GET: AcdfCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcdfCategory/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,CategoryName")] AcdfCategory acdfCategory)
        {
            if (ModelState.IsValid)
            {
                db.AcdfCategories.Add(acdfCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acdfCategory);
        }

        // GET: AcdfCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfCategory acdfCategory = db.AcdfCategories.Find(id);
            if (acdfCategory == null)
            {
                return HttpNotFound();
            }
            return View(acdfCategory);
        }

        // POST: AcdfCategory/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,CategoryName")] AcdfCategory acdfCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acdfCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acdfCategory);
        }

        // GET: AcdfCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfCategory acdfCategory = db.AcdfCategories.Find(id);
            if (acdfCategory == null)
            {
                return HttpNotFound();
            }
            return View(acdfCategory);
        }

        // POST: AcdfCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AcdfCategory acdfCategory = db.AcdfCategories.Find(id);
            db.AcdfCategories.Remove(acdfCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
