using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trips_and_travel_system.Models
{
    public class FAQ
    {
        public FAQ()
        {
            
        }

        public int FAQId { set; get; }
        public string question { set; get; }
        public string answer { set; get; }
    }
}