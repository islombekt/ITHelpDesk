using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHelpDesk.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        public string Building { get; set; }
        public string Block { get; set; }
        public string Flag { get; set; }
    }
}
