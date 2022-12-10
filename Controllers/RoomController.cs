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
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IUserService _userService;
        public RoomController(IRoomRepository repo, IUserService usrSvc)
        {
            _roomRepository = repo;
            _userService = usrSvc;
        }
        [Authorize]
        public PartialViewResult _RoomEditListPartial(RoomListViewModel rooms)
        {
            return PartialView(rooms);
        }
        [Authorize]
        public PartialViewResult _RoomEditListPartial()
        {
            RoomListViewModel rooms = _roomRepository.GetRooms(_userService.GetUserId());
            return PartialView("_RoomEditListPartial", rooms);
        }
        [HttpPost]
        [Authorize]
        public PartialViewResult SaveRoom(RoomViewModel room)
        {
            _roomRepository.SaveRoom(room);
            return PartialView("_RoomEditPartial", room);
        }
        [Authorize]
        public PartialViewResult EditRoom(Guid id)
        {
            RoomViewModel room = _roomRepository.GetRoom(id);
            return PartialView("_RoomEditPartial", room);
        }
        
        public PartialViewResult AddRoom(RoomListViewModel room)
        {
            RoomViewModel newRoom = new RoomViewModel();
            newRoom.RoomId = Guid.NewGuid();
            return PartialView("_RoomEditPartial", newRoom);
        }
    }
}
