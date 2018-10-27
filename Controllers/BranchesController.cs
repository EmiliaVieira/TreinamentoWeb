using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TreinamentoWeb.Models.Entity;

namespace TreinamentoWeb.Controllers
{
    public class BranchesController : Controller
    {
        private treinamentowebEntities db = new treinamentowebEntities();

        // GET: Branches
        // public ActionResult Index(string fltName, int? fltType, int? fltProduct, int? page)
        public ActionResult Index(string fltName, string fltType, string fltProduct, int? page)
        {
            // Se está logado com sucesso
            if (Session["user"] != null) 
            {
                var branches = db.branches.Where(b => (string.IsNullOrEmpty(fltName) || b.name.Contains(fltName)) &&
               (string.IsNullOrEmpty(fltType) || b.type.ToString().Contains(fltType)) &&
               (string.IsNullOrEmpty(fltProduct) || b.product.ToString().Contains(fltProduct))
               ).ToList();

                // var branches = db.branches.Where(b => (string.IsNullOrEmpty(fltName) || b.name.Contains(fltName))).ToList();

                ViewBag.Count = branches.Count;
                ViewBag.Page = page ?? 1;
                return View(branches.OrderBy(b => b.name).Skip(page.HasValue ? ((page.Value - 1) * 10) : 0).Take(10));
            }
            return RedirectToAction("Index", "Login");
            // return View(db.branches.ToList());
        }

        // GET: Branches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            branches branches = db.branches.Find(id);
            if (branches == null)
            {
                return HttpNotFound();
            }
            return View(branches);
        }

        // GET: Branches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Branches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "name,description,merge_executed,parent_branch,type,product,id")] branches branches)
        {
            if (ModelState.IsValid)
            {
                db.branches.Add(branches);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(branches);
        }

        // GET: Branches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            branches branches = db.branches.Find(id);
            if (branches == null)
            {
                return HttpNotFound();
            }
            return View(branches);
        }

        // POST: Branches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "name,description,merge_executed,parent_branch,type,product,id")] branches branches)
        {
            if (ModelState.IsValid)
            {
                db.Entry(branches).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branches);
        }

        // GET: Branches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            branches branches = db.branches.Find(id);
            if (branches == null)
            {
                return HttpNotFound();
            }
            return View(branches);
        }

        // POST: Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            branches branches = db.branches.Find(id);
            db.branches.Remove(branches);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet, ActionName("Branches")]
         public JsonResult ListBranches(string searchTerm, int pageSize, int pageNumber)
        {
            var branches = db.branches.Where(b => (string.IsNullOrEmpty(searchTerm) || b.name.ToLower().Contains(searchTerm.ToLower()))).OrderBy(b => b.name).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return Json(branches, JsonRequestBehavior.AllowGet);
        }

        //  [HttpGet, ActionName("ParentBrancheName")]
        [ActionName("ParentBrancheName")]
        public string ParentBrancheName(int idB)
        {
            branches branches = db.branches.Find(idB);
            return branches.name;
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
