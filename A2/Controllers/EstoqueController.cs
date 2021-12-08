using System.Linq;
using System.Net;
using System.Web.Mvc;
using A2.DAL;
using A2.Models;
using Microsoft.EntityFrameworkCore;

namespace A2.Controllers
{
    public class EstoqueController : Controller
    {
        private Context db = new Context();

        // GET: Estoque
        public ActionResult Index()
        {
            return View(db.Edicoes.ToList());
        }

        //GET: Estoque/SaveEdicao
        public ActionResult SaveEdicao(int? id)
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

        
    }
}