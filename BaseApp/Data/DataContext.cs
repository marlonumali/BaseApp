using BaseApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }

    }
}