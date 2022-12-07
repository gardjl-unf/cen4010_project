using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenBed.Models;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Net.Http;
using System.Security.Claims;
using System.Linq;


namespace OpenBed.Controllers
{
    public class AccountController : Controller
    {
        IShelterRepository repo;
        private Shelter shelter;
        public AccountController (IShelterRepository iShelterRepository)
        {
            repo = iShelterRepository;
            // set shelter to the shelter of the currently logged in user
            // Get current user id
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            shelter = repo.GetShelters().Where(s => s.ShelterID == userId).FirstOrDefault();
        }
        [Authorize]
        public ViewResult Index()
        {
            return View(shelter);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Index(Shelter shelter) 
        { 
            return View(shelter); 
        }

    }
}
