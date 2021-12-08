using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A2.Models;
using A2.DAL;

namespace A2.Controllers
{
    
    public class ClienteController : Controller
    {
        private Context db = new Context();

        public ActionResult Register()
        {
            return View();
        }

        // POST: Editoras/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "id,cpf,nome,senha,email,telefone,endereco")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Home", "Cliente");
            }

            return View(cliente);
        }

        public ActionResult Home()
        {
            return View();
        }

    }
}