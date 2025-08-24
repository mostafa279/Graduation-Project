using Elearning.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Elearning.Infrastructure.Data.Configurations
{
    public class AddressConfigurations : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Governorate)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
