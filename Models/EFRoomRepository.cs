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
        public EFRoomRepository(ApplicationDbContext ctx, IUserService usrSvc)
        {
            context = ctx;
            _userService = usrSvc;
        }
        public IEnumerable<Room> Rooms => context.Rooms;
        public RoomViewModel GetRoom(Guid id)
        {
            Room dbEntry = context.Rooms.FirstOrDefault(r => r.RoomId == id);
            if (dbEntry == null)
            {
                dbEntry = new Room();
                context.Rooms.Add(dbEntry);

            }
            return new RoomViewModel
            {
                RoomId = id,
                RoomDescription = dbEntry.RoomDescription,
                RoomType = dbEntry.RoomType,
                NumberOfBeds = dbEntry.NumberOfBeds
            };
        }
        public void SaveRoom(RoomViewModel room)
        {
            Room dbEntry = context.Rooms.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (dbEntry != null)
            {
                dbEntry.RoomDescription = dbEntry.RoomDescription;
                dbEntry.RoomType = dbEntry.RoomType;
                dbEntry.NumberOfBeds = dbEntry.NumberOfBeds;
            }
            else
            {
                context.Add(new Room
                {
                    Id = _userService.GetUserId(),
                    RoomId = room.RoomId,
                    RoomDescription = room.RoomDescription,
                    RoomType = room.RoomType,
                    NumberOfBeds = room.NumberOfBeds
                });
            }
            context.SaveChanges();
        }
        public RoomListViewModel GetRooms(Guid id)
        {
            RoomListViewModel rooms = new RoomListViewModel();
            foreach (Room r in Rooms.Where(r=>r.Id == id))
            {
                rooms.Rooms.Append(GetRoom(r.Id));
            }
            return rooms;
        }
        public int GetRoomCount(Guid id)
        {
            return Rooms.Where(r => r.Id == id).Count();
        }
        public void Delete(Guid id)
        {
            Room dbEntry = context.Rooms.FirstOrDefault(r => r.RoomId == id);
            if (dbEntry != null)
            {
                context.Rooms.Remove(dbEntry);
                context.SaveChanges();
            }
        }
    }
}
