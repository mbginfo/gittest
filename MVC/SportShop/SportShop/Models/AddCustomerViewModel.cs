using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SportShop.Entities;

namespace SportShop.Models
{
    public class AddCustomerViewModel
    {
       [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    
}