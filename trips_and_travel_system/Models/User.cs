using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trips_and_travel_system.Models
{
    public class User
    {
        public User()
        {
            SavedPosts = new HashSet<Post>();
            TripPosts = new HashSet<Post>();
            fAQs = new HashSet<FAQ>();
            likedPosts = new HashSet<Post>();
            dislikedPosts = new HashSet<Post>();
        }

        public int UserId { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string phone { set; get; }
        public string photo { set; get; }
        public ICollection<Post> SavedPosts { set; get; }
        public ICollection<Post> TripPosts { set; get; }
        public ICollection<FAQ> fAQs { set; get; }
        public ICollection<Post> likedPosts { set; get; }
        public ICollection<Post> dislikedPosts { set; get; }
    }
}