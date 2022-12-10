using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenBed.Models;
using OpenBed.Models.ViewModels;
using OpenBed.Service;
using System;

namespace OpenBed.Controllers
{
    public class ShelterController : Controller
    {
        private readonly IShelterRepository _shelterRepository;
        private readonly IUserService _userService;
        public ShelterController(IShelterRepository repo, IUserService usrSvc)
        {
            _shelterRepository = repo;
            _userService = usrSvc;
        }
        [Authorize]
        public ViewResult Index()
        {
            ShelterViewModel shelter = _shelterRepository.GetShelter(_userService.GetUserId());      
            return View(shelter);
        }
        [HttpPost]
        [Authorize]
        public IActionResult SaveShelter(ShelterViewModel shelter) 
        {
            _shelterRepository.SaveShelter(shelter);
            return View("Index", shelter);
        }
    }
}