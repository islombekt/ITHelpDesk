using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITHelpDesk.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }

        //public int AddressId { get; set; }

        //[ForeignKey("AddressId")]
        //public Address Address { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
