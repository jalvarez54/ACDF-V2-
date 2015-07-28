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
    public class SubCategoryController : Controller
    {
        private AcdfEntities db = new AcdfEntities();

        // GET: AcdfSubCategory
        public ActionResult Index()
        {
            var acdfSubCategories = db.AcdfSubCategories.Include(a => a.AcdfCategory);
            return View(acdfSubCategories.ToList());
        }

        // GET: AcdfSubCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfSubCategory acdfSubCategory = db.AcdfSubCategories.Find(id);
            if (acdfSubCategory == null)
            {
                return HttpNotFound();
            }
            return View(acdfSubCategory);
        }

        // GET: AcdfSubCategory/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.AcdfCategories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: AcdfSubCategory/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubCategoryId,SubCategoryName,IsEnable,CategoryId")] AcdfSubCategory acdfSubCategory)
        {
            if (ModelState.IsValid)
            {
                db.AcdfSubCategories.Add(acdfSubCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.AcdfCategories, "CategoryId", "CategoryName", acdfSubCategory.CategoryId);
            return View(acdfSubCategory);
        }

        // GET: AcdfSubCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfSubCategory acdfSubCategory = db.AcdfSubCategories.Find(id);
            if (acdfSubCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.AcdfCategories, "CategoryId", "CategoryName", acdfSubCategory.CategoryId);
            return View(acdfSubCategory);
        }

        // POST: AcdfSubCategory/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubCategoryId,SubCategoryName,IsEnable,CategoryId")] AcdfSubCategory acdfSubCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acdfSubCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.AcdfCategories, "CategoryId", "CategoryName", acdfSubCategory.CategoryId);
            return View(acdfSubCategory);
        }

        // GET: AcdfSubCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcdfSubCategory acdfSubCategory = db.AcdfSubCategories.Find(id);
            if (acdfSubCategory == null)
            {
                return HttpNotFound();
            }
            return View(acdfSubCategory);
        }

        // POST: AcdfSubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AcdfSubCategory acdfSubCategory = db.AcdfSubCategories.Find(id);
            db.AcdfSubCategories.Remove(acdfSubCategory);
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
