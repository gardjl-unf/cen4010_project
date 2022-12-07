using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenBed.Models
{
    public interface IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
    }
}
