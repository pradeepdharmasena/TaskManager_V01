using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskManager_V01.Models;

namespace TaskManager_V01.DataAccess
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .Property(u => u.AccountID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AppUser>()
                .HasKey(u => u.AccountID);

            modelBuilder.Entity<AppUser>()
                .HasIndex(u => u.Email)
                .IsUnique();

        }
    }
}
