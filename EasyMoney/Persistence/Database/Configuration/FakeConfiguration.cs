using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Database.Configuration
{
    internal class FakeConfiguration : IEntityTypeConfiguration<Fake>
    {
        public void Configure(EntityTypeBuilder<Fake> builder)
        {
            builder.ToTable("Fakes", "EasyMoney");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Value).HasMaxLength(10);
        }
    }
}
