using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Draft.Models.User
{
    public class PropertyAdvisor
    {
        public int PropertyAdvisorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public char Grade { get; set; }
    }
}