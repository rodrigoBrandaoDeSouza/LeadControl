using LeadAPI.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeadApi.Infraestructure.Configurations
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
