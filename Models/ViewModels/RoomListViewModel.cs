using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OpenBed.Models;
using OpenBed.Service;

namespace OpenBed.Models.ViewModels
{
    public class RoomListViewModel
    {
        public IEnumerable<RoomViewModel> Rooms { get; set; }
        public RoomListViewModel getRooms()
        {
            RoomListViewModel roomList = new RoomListViewModel();
            if (Rooms != null)
            {
                roomList.Rooms = Rooms.Select(r => new RoomViewModel
                {
                    RoomId = r.RoomId,
                    RoomType = r.RoomType,
                    RoomDescription = r.RoomDescription,
                    NumberOfBeds = r.NumberOfBeds
                });
            }
            else
            {
                roomList.Rooms = new List<RoomViewModel>();

            }
            return roomList;
        }
        public RoomListViewModel AddRoom(RoomListViewModel rooms)
        {
            rooms.Rooms = rooms.Rooms.Select(r => new RoomViewModel
            {
                RoomId = r.RoomId,
                RoomType = r.RoomType,
                RoomDescription = r.RoomDescription,
                NumberOfBeds = r.NumberOfBeds
            });
            return rooms;
        }
    }
}
