using LeadAPI.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeadApi.Infraestructure.Configurations
{
    public class LeadStatusEntityConfiguration : IEntityTypeConfiguration<LeadStatus>
    {
        public void Configure(EntityTypeBuilder<LeadStatus> builder)
        {
            builder.HasKey(p => p.Id);

            builder.ToTable("LeadStatus");

            builder.HasOne(p => p.Status)
                .WithMany(s => s.LeadStatus)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
