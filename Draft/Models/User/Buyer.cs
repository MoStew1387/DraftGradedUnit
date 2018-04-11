using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Draft.Models.User
{
    public class Buyer
    {
        public int SellerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }    
        public int NumberOfUnviewedAppointments { get; set; }
        [Display(Name = "Terms and Conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree with terms and conditions")]
        public bool TermsAndConditions { get; set; }
    }
}