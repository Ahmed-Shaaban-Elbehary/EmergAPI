﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class Disease
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> users { get; set; }
    }
}