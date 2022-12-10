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
        public IEnumerable<Room> Rooms { get; set; }
    }
}
