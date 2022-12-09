using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Models;

namespace OpenBed.Models.ViewModels
{
    public class RoomListViewModel
    {
        public IEnumerable<RoomViewModel> Rooms { get; set; }
    }
}
