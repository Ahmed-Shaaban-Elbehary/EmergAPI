using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public int? mobileNo { get; set; }

        public string UpImage { get; set; }

        public decimal? Height { get; set; }

        public decimal? Weight { get; set; }

        public Gender Gender { get; set; }

        public BloodType BloodType { get; set; }

        public ICollection<Disease> Diseases { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}