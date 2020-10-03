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
    public class CourseListsController : Controller
    {
        private assessment_ModelContainer db = new assessment_ModelContainer();

        // GET: CourseLists
        public ActionResult Index()
        {
            var courseLists = db.CourseLists.Include(c => c.User).Include(c => c.Course);
            return View(courseLists.ToList());
        }

        // GET: CourseLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseList courseList = db.CourseLists.Find(id);
            if (courseList == null)
            {
                return HttpNotFound();
            }
            return View(courseList);
        }

        // GET: CourseLists/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName");
            return View();
        }

        // POST: CourseLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,CourseId")] CourseList courseList)
        {
            if (ModelState.IsValid)
            {
                db.CourseLists.Add(courseList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", courseList.UserId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseList.CourseId);
            return View(courseList);
        }

        // GET: CourseLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseList courseList = db.CourseLists.Find(id);
            if (courseList == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", courseList.UserId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseList.CourseId);
            return View(courseList);
        }

        // POST: CourseLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,CourseId")] CourseList courseList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", courseList.UserId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseList.CourseId);
            return View(courseList);
        }

        // GET: CourseLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseList courseList = db.CourseLists.Find(id);
            if (courseList == null)
            {
                return HttpNotFound();
            }
            return View(courseList);
        }

        // POST: CourseLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseList courseList = db.CourseLists.Find(id);
            db.CourseLists.Remove(courseList);
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
