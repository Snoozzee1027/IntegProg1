using Microsoft.EntityFrameworkCore;
using activity1.Models;

namespace activity1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<SupplierName> Suppliers { get; set; }
    }
}
