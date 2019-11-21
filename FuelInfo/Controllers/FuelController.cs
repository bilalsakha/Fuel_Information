using FuelInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelInfo.Controllers
{
    public class FuelController : Controller
    {
        Models.Fuel1Entities db = new Models.Fuel1Entities();
        // GET: Fuel
        public ActionResult Index(int n=3,string fueltype="Diesel")
        {
            var lst=db.Fuels.Where(q => q.FuelType == fueltype).ToList();
            if (lst.Count < 3)
            {
                n = 0;
            }
            lst.Reverse();
            var lst1=lst.Take(n);
            return View(lst1);
        }

        // GET: Fuel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fuel/Create

        public ActionResult Create()
        {
            Fuel model = new Fuel();
            model.DateModified = DateTime.Today.Date;
            return View(model);
        }

        // POST: Fuel/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Fuel model)
        {
            if (ModelState.IsValid)
            {
                db.Fuels.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Fuel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fuel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fuel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fuel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
