using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenBed.Models;
using OpenBed.Models.ViewModels;
using OpenBed.Service;


namespace OpenBed.Controllers
{
    public class ShelterController : Controller
    {
        private readonly IShelterRepository _shelterRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IUserService _userService;
        public ShelterController(IShelterRepository repo, IRoomRepository rmrepo, IUserService usrSvc)
        {
            _shelterRepository = repo;
            _roomRepository = rmrepo;
            _userService = usrSvc;
        }
        [Authorize]
        public ViewResult Index()
        {
            Shelter shelter = _shelterRepository.Shelters.FirstOrDefault(s => s.Id == _userService.GetUserId());
            ViewBag.Id = _userService.GetUserId();
            if (shelter == null)
            {
                return View(new ShelterViewModel());
            }
            else
            {
                return View(new ShelterViewModel
                {
                    Id = shelter.Id,
                    ShelterName = shelter.ShelterName,
                    ShelterAddress = shelter.ShelterAddress,
                    ShelterCity = shelter.ShelterCity,
                    ShelterState = shelter.ShelterState,
                    ShelterZip = shelter.ShelterZip,
                    ShelterPhone = shelter.ShelterPhone,
                    ShelterEmail = shelter.ShelterEmail,
                    ShelterWebsite = shelter.ShelterWebsite,
                    ShelterDescription = shelter.ShelterDescription,
                    Rooms = _roomRepository.Rooms.Where(r => r.Id == _userService.GetUserId()).ToList()
                });
            }
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