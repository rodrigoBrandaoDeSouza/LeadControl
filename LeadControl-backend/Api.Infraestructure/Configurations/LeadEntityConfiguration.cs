using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infraestructure.Configurations
{
    public class LeadEntityConfiguration : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Lead");

            builder.Property(p => p.FirstName)
               .HasMaxLength(64)
               .IsRequired();

            builder.Property(p => p.LastName)
               .HasMaxLength(64)
               .IsRequired();

            builder.Property(p => p.Suburb)
               .HasMaxLength(255)
               .IsRequired();

            builder.Property(p => p.Description)
               .HasMaxLength(30)
               .IsRequired();

            builder.Property(p => p.Category)
               .HasMaxLength(30)
               .IsRequired();

            builder.Property(p => p.Price)
               .HasMaxLength(30)
               .IsRequired();
        }
    }
}
