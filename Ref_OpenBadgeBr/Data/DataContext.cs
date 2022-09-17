using Microsoft.EntityFrameworkCore;
using Ref_OpenBadgeBr.Models;

namespace Ref_OpenBadgeBr.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}