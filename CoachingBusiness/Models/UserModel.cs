using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoachingBusiness.Models
{
    public class UserModel : IdentityUser
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
