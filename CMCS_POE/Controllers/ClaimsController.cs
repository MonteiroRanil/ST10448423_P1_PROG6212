using Microsoft.AspNetCore.Mvc;
using CMCS_POE.Models;
using System.Collections.Generic;
using System.Linq;

namespace CMCS_POE.Controllers
{
    public class ClaimsController : Controller
    {
        private static List<Claim> claims = new List<Claim>
        {
            new Claim { Id = 1, LecturerName = "Dr. Smith", ModuleName = "IT101", HoursWorked = 20, Amount = 500, IsVerified = false, IsApproved = false },
            new Claim { Id = 2, LecturerName = "Prof. Adams", ModuleName = "CS202", HoursWorked = 15, Amount = 400, IsVerified = false, IsApproved = false }
        };
        // This is my lecturers dashboard action
        public IActionResult Dashboard()
        {
            return View();
        }

        // My create a new claim action
        public IActionResult Create()
        {
            return View();
        }

        // my upload supporting docs action
        public IActionResult Upload()
        {
            return View();
        }

        // my view claim status action
        public IActionResult Status()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(claims);
        }
        //verify action
        public IActionResult Verify(int id)
        {
            var claim = claims.FirstOrDefault(c => c.Id == id);
            if (claim != null) claim.IsVerified = true;
            return RedirectToAction("Index");
        }
        //approve action
        public IActionResult Approve(int id)
        {
            var claim = claims.FirstOrDefault(c => c.Id == id);
            if (claim != null && claim.IsVerified) claim.IsApproved = true;
            return RedirectToAction("Index");
        }

    }
}