using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class BloodTypeConfiguration:EntityTypeConfiguration<BloodType>
    {
        public BloodTypeConfiguration()
        {
            HasKey(k => k.Id);
            Property(P => P.Name).HasMaxLength(10);

        }
    }
}