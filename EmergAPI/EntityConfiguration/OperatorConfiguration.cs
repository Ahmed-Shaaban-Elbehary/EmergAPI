using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EmergAPI.EntitytypeConfiguration
{
    public class OperatorConfiguration:EntityTypeConfiguration<Operator>
    {
        public OperatorConfiguration()
        {
            HasKey(k => k.Id);

            Property(p => p.Name)
                .HasMaxLength(255);

            Property(p => p.Email)
                .HasMaxLength(255);

            Property(p => p.Password)
                .HasMaxLength(255);

            Property(p => p.ConfirmPassword)
                .HasMaxLength(255);

            Property(p => p.Birthdate)
                .HasColumnType("Date")
                .IsOptional();

            Property(p => p.Hiredate)
                .HasColumnType("Date")
                .IsOptional();

            Property(p => p.Salary)
                .HasColumnType("smallmoney")
                .IsOptional();
            
        }
    }
} 