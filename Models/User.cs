using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authuntication.Models
{
    public class User : IdentityUser
    {
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        public string Country { get; set; }
        
        public string City { get; set; }
       
        public string District { get; set; }

        public byte[] Img { set; get; }
       
        
    }
}
