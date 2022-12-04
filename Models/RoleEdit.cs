using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace cen4010_project.Models
{
    public class RoleEdit
    {
        public IdentityRole<Guid> Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}
