using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenBed.Models
{
    public class IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
        public virtual IEnumerable<Shelter> GetShelters() => Shelters;
        public virtual Shelter GetShelter(Guid id) => Shelters.FirstOrDefault(s => s.ShelterID == id);
        public virtual Boolean ContainsID(Guid id) => Shelters.Any(s => s.ShelterID == id);
    }
}
