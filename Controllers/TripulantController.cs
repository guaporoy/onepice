using onePice.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TripulacionGoingMerry.DAL;
using TripulacionGoingMerry.Models;

namespace onePice.Controllers
{
    public class TripulantController : Controller
    {
        private TripContext db = new TripContext();

        // GET: Tripulant
        public ActionResult Index()
        {
            return View(db.Tripulants.ToList());
        }

        // GET: Tripulant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripulacionGoingMerry.Models.Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }

            return View(tripulant);
        }

        // GET: Tripulant/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Tripulant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,EnrollmentDate")] TripulacionGoingMerry.Models.Tripulant tripulant)
        {
            if (ModelState.IsValid)
            {
                db.Tripulants.Add(tripulant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripulant);
        }

        // GET: Tripulant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripulacionGoingMerry.Models.Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }
            return View(tripulant);
        }

        // POST: Tripulant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,EnrollmentDate")] TripulacionGoingMerry.Models.Tripulant tripulant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripulant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripulant);
        }

        // GET: Tripulant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripulacionGoingMerry.Models.Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }
            return View(tripulant);
        }

        // POST: Tripulant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TripulacionGoingMerry.Models.Tripulant tripulant = db.Tripulants.Find(id);
            db.Tripulants.Remove(tripulant);
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


        

