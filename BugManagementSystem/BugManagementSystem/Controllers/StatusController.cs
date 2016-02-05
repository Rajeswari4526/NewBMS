using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugManagementSystem.Models;
using BugManagementSystem.DAL;

namespace BugManagementSystem.Controllers
{
    public class StatusController : Controller
    {
        private BugContext db = new BugContext();

        //
        // GET: /Status/

        public ActionResult Index()
        {
            return View(db.status.ToList());
        }

        //
        // GET: /Status/Details/5

        public ActionResult Details(int id = 0)
        {
            Status status = db.status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // GET: /Status/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Status/Create

        [HttpPost]
        public ActionResult Create(Status status)
        {
            if (ModelState.IsValid)
            {
                db.status.Add(status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(status);
        }

        //
        // GET: /Status/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Status status = db.status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // POST: /Status/Edit/5

        [HttpPost]
        public ActionResult Edit(Status status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(status);
        }

        //
        // GET: /Status/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Status status = db.status.Find(id);
            if (status == null)
            {
                return HttpNotFound();
            }
            return View(status);
        }

        //
        // POST: /Status/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Status status = db.status.Find(id);
            db.status.Remove(status);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}