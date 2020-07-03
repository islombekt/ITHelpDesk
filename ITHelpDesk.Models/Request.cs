using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ITHelpDesk.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        [Display(Name ="Request Name")]
        [Required]
        [MaxLength(400)] //need to change to 50
        public string RName { get; set; }
        public string RDescription { get; set; }
        public string RStatus { get; set; }
        public byte RWeight { get; set; }
        // Add type information.
        [DataType(DataType.DateTime)]
        public DateTime RDateTime { get; set; }

    }
}
