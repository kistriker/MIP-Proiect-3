using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MagazinOnline.Models;
namespace MagazinOnline.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        private DatabaseDBContext dbCtx = new DatabaseDBContext();
        public ActionResult Index()
        {
            return View(dbCtx.Produse.ToList());
        }
        public ActionResult Garaj()
        {
            ViewData.Model = dbCtx.Produse.ToList();
            return View();
            //return View(dbCtx.Produse.ToList());
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            Database msg = new Database();
            return View(msg);
        }
        [HttpPost]
        public ActionResult Create(Database msg)
        {
            dbCtx.Produse.Add(msg);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            Database msg = dbCtx.Produse.Find(id);
            return View(msg);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Database msg = dbCtx.Produse.Find(id);
            return View(msg);
        }
        [HttpPost]
        public ActionResult Edit(Database msg)
        {
            dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Modified;
            dbCtx.SaveChanges();
            return RedirectToAction("Index");
        }
        /*[HttpGet]
        public ActionResult Delete()
        {
            Database msg = new Database();
            return View(msg);
        }
        [HttpPost]
        public ActionResult Delete(Database msg)
        {
            dbCtx.Produse.Remove(msg);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }*/
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Database msg = dbCtx.Produse.Find(id);
            return View(msg);
        }
        [HttpPost]
        public ActionResult Delete(Database msg)
        {
            //dbCtx.PartiDeSchimb.Remove(msg);
            //dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Modified;
            dbCtx.Entry(msg).State = System.Data.Entity.EntityState.Deleted;
            dbCtx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}