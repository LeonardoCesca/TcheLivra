using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TcheLivra.Models;

namespace TcheLivra.Controllers
{
    public class AnuncioController : Controller
    {
        private TcheLivraDBContext db = new TcheLivraDBContext();

        // GET: Anuncio
        public ActionResult Index()
        {
            var anuncio = db.Anuncio.Include(a => a.Categoria);
            return View(anuncio.ToList());
        }

        // GET: Anuncio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncio.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        // GET: Anuncio/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaID = new SelectList(db.Categoria, "CategoriaID", "Name");
            return View();
        }

        // POST: Anuncio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Description,Data,Director,CategoriaID,ImageFile,ImageMimeType,ImageUrl")] Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                db.Anuncio.Add(anuncio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaID = new SelectList(db.Categoria, "CategoriaID", "Name", anuncio.CategoriaID);
            return View(anuncio);
        }

        // GET: Anuncio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncio.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaID = new SelectList(db.Categoria, "CategoriaID", "Name", anuncio.CategoriaID);
            return View(anuncio);
        }

        // POST: Anuncio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Description,Data,Director,CategoriaID,ImageFile,ImageMimeType,ImageUrl")] Anuncio anuncio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anuncio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaID = new SelectList(db.Categoria, "CategoriaID", "Name", anuncio.CategoriaID);
            return View(anuncio);
        }

        // GET: Anuncio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncio anuncio = db.Anuncio.Find(id);
            if (anuncio == null)
            {
                return HttpNotFound();
            }
            return View(anuncio);
        }

        // POST: Anuncio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anuncio anuncio = db.Anuncio.Find(id);
            db.Anuncio.Remove(anuncio);
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
