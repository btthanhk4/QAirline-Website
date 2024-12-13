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
    public class FlightSchedulesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin/FlightSchedules
        public ActionResult Index()
        {
            var flightSchedules = db.FlightSchedules.Include(f => f.AirPort).Include(f => f.AirPort1).Include(f => f.Plane);
            return View(flightSchedules.ToList());
        }

        // GET: Admin/FlightSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSchedule flightSchedule = db.FlightSchedules.Find(id);
            if (flightSchedule == null)
            {
                return HttpNotFound();
            }
            return View(flightSchedule);
        }

        // GET: Admin/FlightSchedules/Create
        public ActionResult Create()
        {
            ViewBag.from_airport = new SelectList(db.AirPorts, "id", "name");
            ViewBag.to_airport = new SelectList(db.AirPorts, "id", "name");
            ViewBag.plane_id = new SelectList(db.Planes, "id", "name");
            return View();
        }

        // POST: Admin/FlightSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,plane_id,code,from_airport,to_airport,departures_at,arrivals_at,cost")] FlightSchedule flightSchedule)
        {
            if (ModelState.IsValid)
            {
                db.FlightSchedules.Add(flightSchedule);
                db.SaveChanges();
                AlertHelper.setAlert("success", "Tạo dữ liệu chuyến bay thành công.");
                return RedirectToAction("Index");
            }

            ViewBag.from_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.from_airport);
            ViewBag.to_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.to_airport);
            ViewBag.plane_id = new SelectList(db.Planes, "id", "name", flightSchedule.plane_id);
            return View(flightSchedule);
        }

        // GET: Admin/FlightSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSchedule flightSchedule = db.FlightSchedules.Find(id);
            if (flightSchedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.from_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.from_airport);
            ViewBag.to_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.to_airport);
            ViewBag.plane_id = new SelectList(db.Planes, "id", "name", flightSchedule.plane_id);
            return View(flightSchedule);
        }

        // POST: Admin/FlightSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,plane_id,from_airport,to_airport,departures_at,arrivals_at,cost")] FlightSchedule flightSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flightSchedule).State = EntityState.Modified;
                db.SaveChanges();
                AlertHelper.setAlert("success", "Cập nhập thông tin chuyến bay thành công.");
                return RedirectToAction("Index");
            }
            ViewBag.from_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.from_airport);
            ViewBag.to_airport = new SelectList(db.AirPorts, "id", "name", flightSchedule.to_airport);
            ViewBag.plane_id = new SelectList(db.Planes, "id", "name", flightSchedule.plane_id);
            return View(flightSchedule);
        }

        // GET: Admin/FlightSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FlightSchedule flightSchedule = db.FlightSchedules.Find(id);
            db.FlightSchedules.Remove(flightSchedule);
            AlertHelper.setAlert("success", "Xóa dữ liệu chuyến bay thành công.");
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
