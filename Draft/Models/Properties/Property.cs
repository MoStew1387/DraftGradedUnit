using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Draft.Models.User;

namespace Draft.Models.Properties
{
    public abstract class Property
    {
        

        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string Street { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(60)]
        public string City { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string Postcode { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double SellingPrice { get; set; }

        
        
    }
}