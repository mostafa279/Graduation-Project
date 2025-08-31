using Elearning.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Infrastructure.Data.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.Property(s => s.Grade_level)
                   .IsRequired();

            builder.Property(s => s.Date_of_birth)
                   .HasColumnType("date");

            builder.Property(s => s.ImgURL)
                   .HasMaxLength(500)
                   .IsRequired();
        }
    }
}
