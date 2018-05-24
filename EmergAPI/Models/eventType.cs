using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class EventType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}