using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace OpenBed.Models
{
    public class RoleEdit
    {
        public IdentityRole<Guid> Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}
