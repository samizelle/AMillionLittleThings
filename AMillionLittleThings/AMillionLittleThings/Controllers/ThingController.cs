using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AMillionLittleThings.Models;

namespace AMillionLittleThings.Controllers
{
    public class ThingController : Controller
    {
        // GET: Thing
        private ThingDbContext db = new ThingDbContext();

        // GET: Things
        public ActionResult Index()
        {
            return View(db.Things.ToList());
        }

        // GET: Thing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NameID", "Name", "Description", "DateAdded")] Thing thing)
        {
            if (ModelState.IsValid)
            {
                db.Things.Add(thing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thing);
        }

        // GET: Thing/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thing thing = db.Things.Find(id);
            if (thing == null)
            {
                return HttpNotFound();
            }
            return View(thing);
        }

        // POST: Thing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thing thing = db.Things.Find(id);
            db.Things.Remove(thing);
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