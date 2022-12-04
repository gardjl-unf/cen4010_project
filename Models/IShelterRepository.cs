using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OpenBed.Models
{
    public class IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
    }
}
