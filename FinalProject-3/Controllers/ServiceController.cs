using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject_3.Models;

namespace FinalProject_3.Controllers
{
    public class ServiceController : Controller
    {
        private CommunityAssistEntities db = new CommunityAssistEntities();

        //
        // GET: /Service/

        public ActionResult Index()
        {
            return View(db.CommunityServices.ToList());
        }

        //
        // GET: /Service/Details/5

        public ActionResult Details(int id = 0)
        {
            CommunityService communityservice = db.CommunityServices.Find(id);
            if (communityservice == null)
            {
                return HttpNotFound();
            }
            return View(communityservice);
        }

        //
        // GET: /Service/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Service/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CommunityService communityservice)
        {
            if (ModelState.IsValid)
            {
                db.CommunityServices.Add(communityservice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(communityservice);
        }

        //
        // GET: /Service/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CommunityService communityservice = db.CommunityServices.Find(id);
            if (communityservice == null)
            {
                return HttpNotFound();
            }
            return View(communityservice);
        }

        //
        // POST: /Service/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CommunityService communityservice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(communityservice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(communityservice);
        }

        //
        // GET: /Service/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CommunityService communityservice = db.CommunityServices.Find(id);
            if (communityservice == null)
            {
                return HttpNotFound();
            }
            return View(communityservice);
        }

        //
        // POST: /Service/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommunityService communityservice = db.CommunityServices.Find(id);
            db.CommunityServices.Remove(communityservice);
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