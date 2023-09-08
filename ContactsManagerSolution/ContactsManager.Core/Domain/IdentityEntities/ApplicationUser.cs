using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;

namespace ContactsManager.Core.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        // Your additional properties here
        public string? Name { get; set; }
    }
}
