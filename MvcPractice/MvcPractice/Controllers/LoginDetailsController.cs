using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcPractice.Models;

namespace MvcPractice.Controllers
{
    public class LoginDetailsController : Controller
    {
        private MvcPracticeEntities db = new MvcPracticeEntities();

        // GET: LoginDetails
        public ActionResult Index()
        {
            return View(db.LoginDetails.ToList());
        }

        // GET: LoginDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetail loginDetail = db.LoginDetails.Find(id);
            if (loginDetail == null)
            {
                return HttpNotFound();
            }
            return View(loginDetail);
        }

        // GET: LoginDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,Password,FirstName,LastName")] LoginDetail loginDetail)
        {
            if (ModelState.IsValid)
            {
                db.LoginDetails.Add(loginDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loginDetail);
        }

        // GET: LoginDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetail loginDetail = db.LoginDetails.Find(id);
            if (loginDetail == null)
            {
                return HttpNotFound();
            }
            return View(loginDetail);
        }

        // POST: LoginDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,UserName,Password,FirstName,LastName")] LoginDetail loginDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loginDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loginDetail);
        }

        // GET: LoginDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetail loginDetail = db.LoginDetails.Find(id);
            if (loginDetail == null)
            {
                return HttpNotFound();
            }
            return View(loginDetail);
        }

        // POST: LoginDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoginDetail loginDetail = db.LoginDetails.Find(id);
            db.LoginDetails.Remove(loginDetail);
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
