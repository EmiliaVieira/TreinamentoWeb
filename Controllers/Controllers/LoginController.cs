using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreinamentoWeb.Models.DataContract;
using System.Web.Mvc;
using TreinamentoWeb.Models.Entity;


namespace TreinamentoWeb.Controllers
{
    public class LoginController : Controller
    {

        private readonly treinamentowebEntities db = new treinamentowebEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = db.users.Where(u => u.email == login.UserName && u.password == login.Password);

                if (user.Any())
                {
                    Session["user"] = user.First();
                    return RedirectToAction("Index", "Users"); 
                }

                ModelState.AddModelError(string.Empty, "Usuário ou senha incorretos");
            }
            return View("Index", login);

        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return View("Index");
        }
    }
}