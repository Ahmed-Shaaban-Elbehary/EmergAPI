using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class EventTypeConfiguration : EntityTypeConfiguration<EventType>
    {
        public EventTypeConfiguration()
        {
            HasKey(k => k.Id);
            Property(P => P.Name).HasMaxLength(255);
        }
    }
}