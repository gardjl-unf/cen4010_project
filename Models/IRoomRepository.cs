using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBed.Models
{
    public interface IProductRepository
    {
        IEnumerable<Room> Rooms { get; }
        public virtual IEnumerable<Room> GetRooms() => Rooms;
    }
}