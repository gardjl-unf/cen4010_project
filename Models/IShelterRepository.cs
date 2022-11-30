using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cen4010_project.Models
{
    public class IShelterRepository
    {
        IEnumerable<Shelter> Shelters { get; }
    }
}
