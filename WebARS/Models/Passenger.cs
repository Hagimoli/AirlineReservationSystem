using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebARS.Models
{
    //  KHÁCH HÀNG
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateBirth { get; set; }
        public string CitizenId { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}