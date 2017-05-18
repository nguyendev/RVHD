using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RVHD.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Member : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
    }
}
