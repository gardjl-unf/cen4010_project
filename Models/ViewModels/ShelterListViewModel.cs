using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Models;

namespace OpenBed.Models.ViewModels
{
    public class ShelterListViewModel
    {
        public ICollection<Shelter> Shelters { get; set; }
    }
}
