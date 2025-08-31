using Elearning.Core.Entities;
using Elearning.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Infrastructure.Data.Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.Property(i => i.years_experience)
                   .IsRequired();

            builder.Property(i => i.education_background)
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(i => i.certifications)
                   .HasMaxLength(300);

            builder.Property(i => i.average_rating)
                   .HasColumnType("decimal(5,2)");

            builder.Property(i => i.ImgURL)
                   .HasMaxLength(500)
                   .IsRequired();

            builder.Property(i => i.is_available)
                   .HasDefaultValue(true);

            builder.Property(i => i.total_reviews)
                   .HasDefaultValue(0);
        }
    }
}
