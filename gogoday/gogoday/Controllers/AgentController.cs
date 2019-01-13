using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gogoday.Models;

namespace gogoday.Controllers
{
    public class AgentController : Controller
    {
        private gogodayEntities db = new gogodayEntities();

        //
        // GET: /Agent/

        public ActionResult Index()
        {
            return View(db.Agent.ToList());
        }

        //
        // GET: /Agent/Details/5

        public ActionResult Details(int id = 0)
        {
            Agent agent = db.Agent.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            return View(agent);
        }

        //
        // GET: /Agent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Agent/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Agent agent)
        {
            if (ModelState.IsValid)
            {
                db.Agent.Add(agent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agent);
        }

        //
        // GET: /Agent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Agent agent = db.Agent.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            return View(agent);
        }

        //
        // POST: /Agent/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Agent agent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agent);
        }

        //
        // GET: /Agent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Agent agent = db.Agent.Find(id);
            if (agent == null)
            {
                return HttpNotFound();
            }
            return View(agent);
        }

        //
        // POST: /Agent/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agent agent = db.Agent.Find(id);
            db.Agent.Remove(agent);
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