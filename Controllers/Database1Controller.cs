using MagazinOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagazinOnline.Controllers
{
    public class Database1Controller : Controller
    {
        // GET: Database1
        private Database1DBContext dbCtx = new Database1DBContext();
        public ActionResult Index()
        {
            return View(dbCtx.PartiDeSchimb.ToList());
        }
        public ActionResult PieseDeSchimb()
        {
            ViewData.Model = dbCtx.PartiDeSchimb.ToList();
            return View();
            //return View(dbCtx.Produse.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            Database1 msg = new Database1();
            return View(msg);
        }
        [HttpPost]
        public ActionResult Create(Database1 msg)
        {
            dbCtx.PartiDeSchimb.Add(msg);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            Database1 msg = dbCtx.PartiDeSchimb.Find(id);
            return View(msg);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Database1 msg = dbCtx.PartiDeSchimb.Find(id);
            return View(msg);
        }
        [HttpPost]
        public ActionResult Edit(Database1 msg)
        {
            dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Modified;
            dbCtx.SaveChanges();
            return RedirectToAction("Index");
        }
        /*[HttpGet]
        public ActionResult Delete()
        {
            Database1 msg = new Database1();
            return View(msg);
        }
        [HttpPost]
        public ActionResult Delete(Database1 msg)
        {
            dbCtx.PartiDeSchimb.Remove(msg);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }*/
        /*[HttpPost]
        public ActionResult Delete(int id)
        {
            Database1 produs = new Database1();
            produs.DeleteProdus(id);
            return RedirectToAction("Index");
        }*/
        
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Database1 msg = dbCtx.PartiDeSchimb.Find(id);
            return View(msg);
        }
        [HttpPost]
        public ActionResult Delete(Database1 msg)
        {
            //dbCtx.PartiDeSchimb.Remove(msg);
            //dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Modified;
            dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Deleted;
            dbCtx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}