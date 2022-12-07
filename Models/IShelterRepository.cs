using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenBed.Models
{
    public interface IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
        public virtual IEnumerable<Shelter> GetShelters() => Shelters;
        public virtual Boolean ContainsID(Guid id) => Shelters.Any(s => s.ShelterID == id);
    }
}
