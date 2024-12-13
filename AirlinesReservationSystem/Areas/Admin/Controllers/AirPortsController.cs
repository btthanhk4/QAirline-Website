using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirlinesReservationSystem.Models;
using AirlinesReservationSystem.Helper;

namespace AirlinesReservationSystem.Areas.Admin.Controllers
{
    public class AirPortsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin/AirPorts
        public ActionResult Index()
        {
            return View(db.AirPorts.ToList());
        }

        // GET: Admin/AirPorts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirPort airPort = db.AirPorts.Find(id);
            if (airPort == null)
            {
                return HttpNotFound();
            }
            return View(airPort);
        }

        // GET: Admin/AirPorts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AirPorts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,code,address")] AirPort airPort)
        {
            if (ModelState.IsValid)
            {
                db.AirPorts.Add(airPort);
                db.SaveChanges();
                AlertHelper.setAlert("success", "Tạo dữ liệu sân bay thành công.");
                return RedirectToAction("Index");
            }

            return View(airPort);
        }

        // GET: Admin/AirPorts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirPort airPort = db.AirPorts.Find(id);
            if (airPort == null)
            {
                return HttpNotFound();
            }
            return View(airPort);
        }

        // POST: Admin/AirPorts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,code,address")] AirPort airPort)
        {
            if (ModelState.IsValid)
            {
                db.Entry(airPort).State = EntityState.Modified;
                db.SaveChanges();
                AlertHelper.setAlert("success", "Cập nhập thông tin sân bay thành công.");
                return RedirectToAction("Index");
            }
            return View(airPort);
        }

        // GET: Admin/AirPorts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AirPort airPort = db.AirPorts.Find(id);
            if (airPort == null)
            {
                return HttpNotFound();
            }
            return View(airPort);
        }

        // POST: Admin/AirPorts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AirPort airPort = db.AirPorts.Find(id);
            db.AirPorts.Remove(airPort);
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
