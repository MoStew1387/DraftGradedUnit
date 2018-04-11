using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Draft.Models.User;

namespace Draft.Models.Schedule
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public int OfficeManagerId { get; set; }
        public int SellerId { get; set; }

        public OfficeManager OfficeManager { get; set; }
        public Seller Seller { get; set; }
    }
}