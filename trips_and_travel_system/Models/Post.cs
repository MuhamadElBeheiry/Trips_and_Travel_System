using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trips_and_travel_system.Models
{
    public class Post
    {
        public Post()
        {
            Users = new HashSet<User>();
        }

        public int PostId { set; get; }
        public int agencyId { set; get; }
        public string title { set; get; }
        public string details { set; get; }
        public string tripDestination { set; get; }
        public string tripImage { set; get; }
        public int tripPrice { set; get; }
        public DateTime tripDate { set; get; }
        public DateTime postDate { set; get; }
        public bool accepted { set; get; }
        public User Agency { set; get; }
        public ICollection<User> Users { set; get; }
    }
}