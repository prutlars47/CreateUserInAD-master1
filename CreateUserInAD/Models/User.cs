using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CreateUserInAD.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required, DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required, DisplayName("Last name")]
        public string Lastname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [DisplayName("Street address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Telephone { get; set; }
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string OU { get; set; }

    }
}