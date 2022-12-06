using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenBed.Models;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Net.Http;
using System.Security.Claims;

namespace OpenBed.Controllers
{
    public class AccountController : Controller
    {
        IShelterRepository repo;
        private Shelter shelter;
        public AccountController (IShelterRepository iShelterRepository)
        {
            repo = iShelterRepository;
            shelter = repo.GetShelter(Guid.Parse(this.User.FindFirst(ClaimTypes.NameIdentifier).Value));
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
