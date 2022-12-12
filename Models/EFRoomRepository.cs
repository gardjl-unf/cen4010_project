using Microsoft.AspNetCore.Mvc;
using OpenBed.Data;
using OpenBed.Models.ViewModels;
using OpenBed.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenBed.Models
{
    public class EFRoomRepository : IRoomRepository
    {
        private ApplicationDbContext context;
        private readonly IUserService _userService;
        public IEnumerable<Room> Rooms => context.Rooms;
        public EFRoomRepository(ApplicationDbContext ctx, IUserService usrSvc)
        {
            context = ctx;
            _userService = usrSvc;
        }
        public void SaveRoom(Room room)
        {
            Room dbEntry = context.Rooms.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (dbEntry != null)
            {
                dbEntry.RoomDescription = room.RoomDescription;
                dbEntry.RoomType = room.RoomType;
                dbEntry.NumberOfBeds = room.NumberOfBeds;
            }
            else
            {
                context.Add(new Room
                {
                    Id = _userService.GetUserId(),
                    RoomId = room.RoomId,
                    RoomDescription = room.RoomDescription,
                    RoomType = room.RoomType,
                    NumberOfBeds = room.NumberOfBeds,
                    NumberOfBedsOccupied = room.NumberOfBedsOccupied
                });
            }
            context.SaveChanges();
        }
        public void DeleteRoom(Guid RoomId)
        {
            Room dbEntry = context.Rooms.FirstOrDefault(r => r.RoomId == RoomId);
            if (dbEntry != null)
            {
                context.Rooms.Remove(dbEntry);
                context.SaveChanges();
            }
        }
    }
}
