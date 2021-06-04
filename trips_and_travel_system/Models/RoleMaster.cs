using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trips_and_travel_system.Models
{
    public class RoleMaster
    {
        public RoleMaster()
        {
            users = new HashSet<User>();
        }
        public int RoleId { set; get; }
        public string RoleName { set; get; }
        public ICollection<User> users { set; get; }
    }
}