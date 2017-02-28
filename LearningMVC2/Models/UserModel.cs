using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningMVC2.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Depature { get; set; }
        public int UserID { get; set; }
    }
}