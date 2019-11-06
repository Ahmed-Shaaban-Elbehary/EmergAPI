using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string dateTime { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public EventType EventType { get; set; }

        public bool IsProcessed { get; set; }

        public Event()
        {
            IsProcessed = false;

        }
    }
}