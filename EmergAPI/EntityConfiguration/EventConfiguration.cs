using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class EventConfiguration:EntityTypeConfiguration<Event>
    {

        public EventConfiguration()
        {
            HasKey(k => k.Id);

            HasRequired(e => e.EventType)
                .WithMany(et => et.Events)
                .Map(k => k.MapKey("EvenTypetId"));
        } 

    }
}
