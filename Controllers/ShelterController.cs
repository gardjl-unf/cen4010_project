using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenBed.Models;
using OpenBed.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace OpenBed.Controllers
{
    public class ShelterController : Controller
    {
        private IShelterRepository _shelterRepository;
        public int PageSize = 4;
        public ShelterController(IShelterRepository repo)
        {
            _shelterRepository = repo;
        }
        [Authorize]
        public ViewResult Index()
        {
            return View(new ShelterViewModel
            {
                Shelter = _shelterRepository.Shelters.Where(p => p.ShelterID == Guid.Parse(User.Identity.Name)).FirstOrDefault()

            });
        }
    }
}