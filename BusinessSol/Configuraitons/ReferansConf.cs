using BusinessSol.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessSol.Configuraitons
{
    public class ReferansConf : IEntityTypeConfiguration<Referans>
    {
        public void Configure(EntityTypeBuilder<Referans> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.HasOne(p => p.RefCategory).WithMany(p => p.Referanslar).HasForeignKey(p => p.RefCategoryId);
        }
    }
}
