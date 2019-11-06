using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class Disease
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }
        
        //public ICollection<User> users { get; set; }
    }
}