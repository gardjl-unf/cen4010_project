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
        public ShelterViewModel GetShelter(Guid id);
        public ShelterListViewModel GetShelters();
        public int GetShelterCount();
    }
}
