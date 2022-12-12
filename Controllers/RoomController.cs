using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OpenBed.Models;
using OpenBed.Models.ViewModels;
using OpenBed.Service;
using System;
using System.Threading.Tasks;

namespace OpenBed.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IUserService _userService;
        public RoomController(IRoomRepository repo, IUserService usrSvc)
        {
            _roomRepository = repo;
            _userService = usrSvc;
        }
        [HttpPost]
        [Authorize]
        public ActionResult Save(Room room)
        {
            _roomRepository.SaveRoom(room);
            return PartialView("_RoomEditListPartial", new RoomListViewModel { Rooms = _roomRepository.Rooms.Where(r => r.Id == _userService.GetUserId()) });
        }
        [Authorize]
        public ActionResult Edit(Guid id)
        {
            return View("_RoomEditPartial", _roomRepository.Rooms.FirstOrDefault(r => r.RoomId == id));
        }
        [Authorize]
        public ActionResult Add()
        {
            return View("_RoomEditPartial", new Room());
        }
        [Authorize]
        public ActionResult Delete(Guid id)
        {
            _roomRepository.DeleteRoom(id);
            return View("_RoomEditListPartial", new RoomListViewModel { Rooms = _roomRepository.Rooms.Where(r => r.Id == _userService.GetUserId()) });
        }
        [Authorize]
        public PartialViewResult _RoomEditListPartial (RoomListViewModel rvlm)
        {
            return PartialView(rvlm);
        }
        [Authorize]
        public PartialViewResult _RoomEditPartial (Room room)
        {
            return PartialView(room);
        }
    }
}
