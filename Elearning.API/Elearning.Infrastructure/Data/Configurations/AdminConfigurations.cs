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
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(a => a.permissions)
                  .HasMaxLength(200);

            builder.Property(a => a.ImgURL)
                   .HasMaxLength(500);

            builder.Property(a => a.last_login)
                   .HasColumnType("datetime");
        }
    }
}
