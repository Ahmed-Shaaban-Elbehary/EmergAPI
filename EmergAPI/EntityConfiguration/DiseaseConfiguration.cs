using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class DiseaseConfiguration:EntityTypeConfiguration<Disease>
    {
        public DiseaseConfiguration()
        {
            HasKey(k => k.Id);
            Property(P => P.Name).HasMaxLength(10);
        }
    }
}