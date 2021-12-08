using System;
using System.Web.Mvc;
using A2.Models;
using A2.DAL;

namespace A2.Controllers
{
    public class LivrariaController : Controller
    {
        private Context db = new Context();

        public ActionResult Register()
        {
            return View();
        }

        // POST: Editoras/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "id,cnpj,nome,senha,email,telefone,endereco")] Livraria livraria)
        {
            if (ModelState.IsValid)
            {
                db.Livrarias.Add(livraria);
                db.SaveChanges();
                return RedirectToAction("Index", "Estoque");
            }

            return View(livraria);
        }
    }
}