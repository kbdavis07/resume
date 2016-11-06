using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modules.Resume.DAL;
using Resume.Models;

namespace Resume.Modules.Resume.Controllers
{
    public class ResumeController : Controller
    {
        private ResumeContext db = new ResumeContext();

        // GET: Resume
        public async Task<ActionResult> Index()
        {
            return View(await db.Resumes.ToListAsync());
        }

        // GET: Resume/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeObject resumeObject = await db.Resumes.FindAsync(id);
            if (resumeObject == null)
            {
                return HttpNotFound();
            }
            return View(resumeObject);
        }

        // GET: Resume/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resume/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id")] ResumeObject resumeObject)
        {
            if (ModelState.IsValid)
            {
                resumeObject.Id = Guid.NewGuid();
                db.Resumes.Add(resumeObject);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(resumeObject);
        }

        // GET: Resume/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeObject resumeObject = await db.Resumes.FindAsync(id);
            if (resumeObject == null)
            {
                return HttpNotFound();
            }
            return View(resumeObject);
        }

        // POST: Resume/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id")] ResumeObject resumeObject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resumeObject).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(resumeObject);
        }

        // GET: Resume/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResumeObject resumeObject = await db.Resumes.FindAsync(id);
            if (resumeObject == null)
            {
                return HttpNotFound();
            }
            return View(resumeObject);
        }

        // POST: Resume/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            ResumeObject resumeObject = await db.Resumes.FindAsync(id);
            db.Resumes.Remove(resumeObject);
            await db.SaveChangesAsync();
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
