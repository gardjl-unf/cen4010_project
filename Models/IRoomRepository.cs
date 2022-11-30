using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cen4010_project.Models
{
    public interface IProductRepository
    {
        IEnumerable<Room> Rooms { get; }
    }
}