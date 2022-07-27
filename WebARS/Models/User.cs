using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebARS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PaswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}