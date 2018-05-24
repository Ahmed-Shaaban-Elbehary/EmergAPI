using EmergAPI.EntitytypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmergAPI.Models
{
    public class _dbContext: DbContext
    {
        public _dbContext():base("ContextConnect")
        {
            Database.SetInitializer<_dbContext>(null);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Operator> Operators { get; set; }

        public DbSet<BloodType> BloodTypes { get; set; }

        public DbSet<Disease> Diseases { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventType> eventTypes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new OperatorConfiguration());
            modelBuilder.Configurations.Add(new BloodTypeConfiguration());
            modelBuilder.Configurations.Add(new DiseaseConfiguration());
            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new EventTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}