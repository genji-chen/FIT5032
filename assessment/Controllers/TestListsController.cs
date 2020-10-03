using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assessment.Models;

namespace assessment.Controllers
{
    public class TestListsController : Controller
    {
        private assessment_ModelContainer db = new assessment_ModelContainer();

        // GET: TestLists
        public ActionResult Index()
        {
            var testLists = db.TestLists.Include(t => t.User).Include(t => t.Test);
            return View(testLists.ToList());
        }

        // GET: TestLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestList testList = db.TestLists.Find(id);
            if (testList == null)
            {
                return HttpNotFound();
            }
            return View(testList);
        }

        // GET: TestLists/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            ViewBag.TestId = new SelectList(db.Tests, "Id", "Date");
            return View();
        }

        // POST: TestLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,state,UserId,TestId")] TestList testList)
        {
            if (ModelState.IsValid)
            {
                db.TestLists.Add(testList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", testList.UserId);
            ViewBag.TestId = new SelectList(db.Tests, "Id", "Date", testList.TestId);
            return View(testList);
        }

        // GET: TestLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestList testList = db.TestLists.Find(id);
            if (testList == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", testList.UserId);
            ViewBag.TestId = new SelectList(db.Tests, "Id", "Date", testList.TestId);
            return View(testList);
        }

        // POST: TestLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,state,UserId,TestId")] TestList testList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", testList.UserId);
            ViewBag.TestId = new SelectList(db.Tests, "Id", "Date", testList.TestId);
            return View(testList);
        }

        // GET: TestLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestList testList = db.TestLists.Find(id);
            if (testList == null)
            {
                return HttpNotFound();
            }
            return View(testList);
        }

        // POST: TestLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestList testList = db.TestLists.Find(id);
            db.TestLists.Remove(testList);
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
