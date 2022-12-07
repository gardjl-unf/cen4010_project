using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Models.ViewModels;

namespace OpenBed.Models
{
    public interface IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
        public void SaveShelter(ShelterViewModel shelter);
        public Shelter GetShelter(Guid id);
    }
}
