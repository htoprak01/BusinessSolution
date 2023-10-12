using Microsoft.EntityFrameworkCore;

namespace BusinessSol.Models
{
    public class OptimalDbContext:DbContext
    {
        public OptimalDbContext(DbContextOptions<OptimalDbContext> options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<RefCategory> RefCategories { get; set; }
        public DbSet<Referans> Referanlar { get; set; }

    }
}
