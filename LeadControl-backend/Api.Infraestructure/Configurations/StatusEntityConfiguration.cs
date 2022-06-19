using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infraestructure.Configurations
{
    public class StatusEntityConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("Status");

            builder.Property(p => p.Description)
               .HasMaxLength(155)
               .IsRequired();
        }
    }
}
