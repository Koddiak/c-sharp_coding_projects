﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,FullCoverage,LiabilityCoverage,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //Set coverage type.
                if (insuree.FullCoverage == true)
                {
                    insuree.CoverageType = "Full";
                }
                else if (insuree.LiabilityCoverage == true)
                {
                    insuree.CoverageType = "Liability";
                }
                else
                {
                    insuree.CoverageType = "None";
                }
                //End set coverage type.

                //Quote calculation.
                if ((DateTime.Now.Year - insuree.DateOfBirth.Year) <= 18)
                {
                    insuree.Quote += 100;
                }
                else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 18 && (DateTime.Now.Year - insuree.DateOfBirth.Year) <= 25)
                {
                    insuree.Quote += 50;
                }
                else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 25)
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche")
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25;
                }

                for (int i = 0; i < insuree.SpeedingTickets; i++)
                {
                    insuree.Quote += 10;
                }

                if (insuree.DUI == true)
                {
                    decimal dui = insuree.Quote / 4;
                    insuree.Quote += dui;
                }
                else if (insuree.DUI == true && insuree.FullCoverage == true)
                {
                    decimal dui = insuree.Quote / 4;
                    decimal full = insuree.Quote / 2;
                    insuree.Quote += (dui + full);
                }
                else if (insuree.FullCoverage == true)
                {
                    decimal full = insuree.Quote / 2;
                    insuree.Quote += full;
                }
                //End quote calculation.

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,FullCoverage,LiabilityCoverage,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //Set coverage type.
                if (insuree.FullCoverage == true)
                {
                    insuree.CoverageType = "Full";
                }
                else if (insuree.LiabilityCoverage == true)
                {
                    insuree.CoverageType = "Liability";
                }
                else
                {
                    insuree.CoverageType = "None";
                }
                //End set coverage type.

                //Quote calculation.
                if ((DateTime.Now.Year - insuree.DateOfBirth.Year) <= 18)
                {
                    insuree.Quote += 100;
                }
                else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 18 && (DateTime.Now.Year - insuree.DateOfBirth.Year) <= 25)
                {
                    insuree.Quote += 50;
                }
                else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 25)
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche")
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25;
                }

                for (int i = 0; i < insuree.SpeedingTickets; i++)
                {
                    insuree.Quote += 10;
                }

                if (insuree.DUI == true)
                {
                    decimal dui = insuree.Quote / 4;
                    insuree.Quote += dui;
                }
                else if (insuree.DUI == true && insuree.FullCoverage == true)
                {
                    decimal dui = insuree.Quote / 4;
                    decimal full = insuree.Quote / 2;
                    insuree.Quote += (dui + full);
                }
                else if (insuree.FullCoverage == true)
                {
                    decimal full = insuree.Quote / 2;
                    insuree.Quote += full;
                }
                //End quote calculation.

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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