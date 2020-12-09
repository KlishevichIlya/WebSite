using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class User : IdentityUser
    {
        //public int UserId { get; set; }
       // public string Login { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool isVIP { get; set; }

        public List<Order> Orders { get; set; }
    }
}
