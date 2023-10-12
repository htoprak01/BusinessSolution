using BusinessSol.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessSol.Configuraitons
{
    public class RefCategoryConf : IEntityTypeConfiguration<RefCategory>
    {
        public void Configure(EntityTypeBuilder<RefCategory> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
