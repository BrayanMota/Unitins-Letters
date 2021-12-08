using System.Linq;
using System.Net;
using System.Web.Mvc;
using A2.DAL;
using A2.Models;
using Microsoft.EntityFrameworkCore;

namespace A2.Controllers
{
    public class EdicaoController : Controller
    {
        private Context db = new Context();

        // GET: Edicao
        public ActionResult Index()
        {
            return View(db.Edicoes.ToList());
        }

        // GET: Edicao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Edicao edicao = db.Edicoes.Find(id);
            if (edicao == null)
            {
                return HttpNotFound();
            }
            return View(edicao);
        }

        // GET: Edicao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edicao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,preco,ano,paginas,nome,autor,sinopse")] Edicao edicao)
        {
            if (ModelState.IsValid)
            {
                db.Edicoes.Add(edicao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(edicao);
        }

        // GET: Edicao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Edicao edicao = db.Edicoes.Find(id);
            if (edicao == null)
            {
                return HttpNotFound();
            }
            return View(edicao);
        }

        // POST: Edicao/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,preco,ano,paginas,nome,autor,sinopse")] Edicao edicao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(edicao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(edicao);
        }

        // GET: Edicao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Edicao edicao = db.Edicoes.Find(id);
            if (edicao == null)
            {
                return HttpNotFound();
            }
            return View(edicao);
        }

        // POST: Edicao/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Edicao edicao = db.Edicoes.Find(id);
            db.Edicoes.Remove(edicao);
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
