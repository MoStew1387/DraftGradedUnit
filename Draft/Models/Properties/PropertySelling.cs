using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Draft.Models.User;

namespace Draft.Models.Properties
{
    public class PropertySelling : Property
    {
        [Key]
        public int PropertySellingId { get; set; }

        [Required]
        public DateTime ViewingStartDate { get; set; }

        [Required]
        public DateTime ViewingEndDate { get; set; }

        [Required]
        public int SellerId { get; set; }

        public Seller Seller { get; set; }
    }
}