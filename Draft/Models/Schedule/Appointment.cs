using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Draft.Models.User;

namespace Draft.Models.Schedule
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Required]
        public int PropertyAdvisorId { get; set; }

        [Required]
        public int BuyerId { get; set; }

        public PropertyAdvisor PropertyAdvisor { get; set; }
        public Buyer Buyer { get; set; }
    }
}