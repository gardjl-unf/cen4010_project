using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenBed.Models;
using OpenBed.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections;
using AutoMapper;

namespace OpenBed.Controllers
{
    public class ShelterController : Controller
    {
        private IShelterRepository _shelterRepository;
        private readonly IMapper _mapper;
        public ShelterController(IShelterRepository repo, IMapper mapper)
        {
            _shelterRepository = repo;
        }
        [Authorize]
        public ViewResult Index()
        {
            ShelterViewModel shelter = new ShelterViewModel();
            //ShelterViewModel shelter = _mapper.Map<ShelterViewModel>(_shelterRepository.Shelters.FirstOrDefault(p => p.ShelterID == Guid.Parse(User.Identity.Name)));
            return View(shelter);
        }
        [HttpPost]
        [Authorize]
        public IActionResult SaveShelter(ShelterViewModel shelter) 
        {
            _shelterRepository.SaveShelter(shelter);
            return View("Index");
        }
    }
}