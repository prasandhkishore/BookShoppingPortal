using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace BookShoppingPortal.Models
{
    public class SignUpViewModel
    {

        
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public byte Age { get; set; }
    }
}