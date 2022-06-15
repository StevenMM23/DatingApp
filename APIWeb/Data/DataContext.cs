using APIWeb.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
