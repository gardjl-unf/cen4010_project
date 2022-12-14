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
        public void SaveRoom(Room room);
        public void DeleteRoom(Guid id);
    }
}