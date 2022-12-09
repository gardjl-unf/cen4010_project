using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Models;

namespace OpenBed.Models.ViewModels
{
    public class ShelterListViewModel
    {
        public IEnumerable<ShelterViewModel> Shelters { get; set; }
        public virtual Boolean ContainsID(Guid id) => Shelters.Any(s => s.Id == id);
        public virtual int Count() => Shelters.Count();
    }
}
