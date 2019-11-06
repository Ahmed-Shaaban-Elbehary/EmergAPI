using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {

            //Property of entity
            HasKey(k => k.Id);

            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Password)
                .HasMaxLength(255);

            Property(p => p.ConfirmPassword)
                .HasMaxLength(255);

            Property(p => p.Email)
                .HasMaxLength(255);


            Property(p => p.UpImage)
                .HasMaxLength(1000)
                .IsOptional();

            Property(p => p.Height)
                .HasPrecision(9, 2);

            Property(p => p.Weight)
                .HasPrecision(9, 2);
            
            //HasRequired(u => u.BloodType)
            //    .WithMany(b => b.Users)
            //    .Map(k => k.MapKey("BloodTypeId"));

            //HasMany(u => u.Diseases)
            //    .WithMany(d => d.users)
            //    .Map(m =>
            //   {
            //       m.ToTable("UsersDiseases");
            //       m.MapLeftKey("UserId");
            //       m.MapRightKey("DiseaseId");

            //   });

            //HasMany(U => U.Events)
            //    .WithRequired(E => E.User)
            //    .Map(k => k.MapKey("UserId"));

        }
    }
}