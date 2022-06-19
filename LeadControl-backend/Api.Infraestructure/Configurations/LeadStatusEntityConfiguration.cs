using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infraestructure.Configurations
{
    public class LeadStatusEntityConfiguration : IEntityTypeConfiguration<LeadStatus>
    {
        public void Configure(EntityTypeBuilder<LeadStatus> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("LeadStatus");

            builder.HasOne(p => p.Lead)
                .WithOne(s => s.LeadStatus);
        }
    }
}
