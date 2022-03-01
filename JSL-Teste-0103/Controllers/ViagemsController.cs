using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JSL_Teste_0103.Models;

namespace JSL_Teste_0103.Controllers
{
    public class ViagemsController : Controller
    {
        private Context2 db = new Context2();

        // GET: Viagems
        public ActionResult Index()
        {
            return View(db.Viagems.ToList());
        }

        // GET: Viagems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagem viagem = db.Viagems.Find(id);
            if (viagem == null)
            {
                return HttpNotFound();
            }
            return View(viagem);
        }

        // GET: Viagems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Viagems/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,dataViagem,localSaida,localEntrega,KmViagem")] Viagem viagem)
        {
            if (ModelState.IsValid)
            {
                db.Viagems.Add(viagem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viagem);
        }

        // GET: Viagems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagem viagem = db.Viagems.Find(id);
            if (viagem == null)
            {
                return HttpNotFound();
            }
            return View(viagem);
        }

        // POST: Viagems/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,dataViagem,localSaida,localEntrega,KmViagem")] Viagem viagem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viagem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viagem);
        }

        // GET: Viagems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagem viagem = db.Viagems.Find(id);
            if (viagem == null)
            {
                return HttpNotFound();
            }
            return View(viagem);
        }

        // POST: Viagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viagem viagem = db.Viagems.Find(id);
            db.Viagems.Remove(viagem);
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
