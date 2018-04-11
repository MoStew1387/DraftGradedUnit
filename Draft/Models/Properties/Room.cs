using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Draft.Models.Properties
{
    public class Room
    {
        public int RoomId { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Value for {0} must {1} or higher")]
        [MaxLength(20, ErrorMessage = "Value for {0} must {1} or lower")]
        public string Type { get; set; }

        [Required]
        [MinLength(20, ErrorMessage = "Value for {0} must {1} or higher")]
        [MaxLength(300, ErrorMessage = "Value for {0} must {1} or lower")]
        public string Description { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Value for {0} must {1} or higher")]
        [MaxLength(20, ErrorMessage = "Value for {0} must {1} or lower")]
        public string Measurements { get; set; }

        [Required]
        public int PropertyId { get; set; }

        public PropertySelling PropertySelling { get; set; }
    }
}