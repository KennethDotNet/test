using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAuth.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
