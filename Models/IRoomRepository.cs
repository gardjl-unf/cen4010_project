using OpenBed.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBed.Models
{
    public interface IRoomRepository
    {
        IEnumerable<Room> Rooms { get; }
        public void SaveRoom(RoomViewModel room);
        public RoomViewModel GetRoom(Guid id);
        public RoomListViewModel GetRooms(Guid id);
        public int GetRoomCount(Guid id);
    }
}