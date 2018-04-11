using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Draft.Models.Properties;

namespace Draft.Models.Schedule
{
    public class Sched
    {
        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime AppointmentSched { get; set; }
        
        [Required]
        public PropertySelling PropertyToSelling { get; set; }
    }
}