using System;
using System.Linq;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsuranceDbContext db = new InsuranceDbContext();

        public ActionResult Index() { return RedirectToAction("Create"); }
        [HttpGet] public ActionResult Create() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insuree insuree)
        {
            if (insuree.DateOfBirth.Date > DateTime.Today || insuree.DateOfBirth.Year < 1900)
                ModelState.AddModelError("DateOfBirth", "Enter a valid past birth date.");
            if (insuree.CarYear > DateTime.Today.Year + 1)
                ModelState.AddModelError("CarYear", "Enter a valid car year.");

            // The quote is computed by the server, never accepted from a form field.
            ModelState.Remove("Quote");
            if (!ModelState.IsValid) return View(insuree);

            decimal quote = 50m;
            int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;

            if (age <= 18) quote += 100m;
            else if (age <= 25) quote += 50m;
            else quote += 25m;

            if (insuree.CarYear < 2000) quote += 25m;
            if (insuree.CarYear > 2015) quote += 25m;

            if (string.Equals((insuree.CarMake ?? "").Trim(), "Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;
                if (string.Equals((insuree.CarModel ?? "").Trim(), "911 Carrera", StringComparison.OrdinalIgnoreCase))
                    quote += 25m;
            }

            quote += insuree.SpeedingTickets * 10m;
            if (insuree.DUI) quote *= 1.25m;
            if (insuree.CoverageType) quote *= 1.50m;
            insuree.Quote = Math.Round(quote, 2, MidpointRounding.AwayFromZero);
            db.Insurees.Add(insuree);
            db.SaveChanges();
            return RedirectToAction("Success");
        }

        public ActionResult Success() { return View(); }

        // Coursework demo only: add authentication and administrator authorization before real deployment.
        public ActionResult Admin()
        {
            return View(db.Insurees.OrderByDescending(i => i.Id).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
