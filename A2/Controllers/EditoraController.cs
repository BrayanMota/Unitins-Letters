using System.Web.Mvc;
using A2.Models;
using A2.DAL;
using Microsoft.EntityFrameworkCore;

namespace A2.Controllers
{
    public class EditoraController : Controller
    {
        private Context db = new Context();

        // GET: Editora/Register

        public ActionResult Register()
        {
            return View();
        }

        // POST: Editoras/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "id,cnpj,nome,senha,email,telefone,endereco")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                db.Editoras.Add(editora);
                db.SaveChanges();
                return RedirectToAction("Index", "Edicao");
            }

            return View(editora);
        }
    }
}