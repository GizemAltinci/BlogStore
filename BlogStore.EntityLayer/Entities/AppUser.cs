using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.EntityLayer.Entities
{
    internal class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
