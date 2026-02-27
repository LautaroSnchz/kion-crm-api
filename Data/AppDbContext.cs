using Microsoft.EntityFrameworkCore;
using KionCRM.API.Models;

namespace KionCRM.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed usuarios iniciales
            // admin123 y demo123 hasheados estáticamente con BCrypt
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Admin User",
                    Email = "admin@kioncrm.com",
                    PasswordHash = "$2a$11$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2uheWG/igi.",
                    Role = "admin"
                },
                new User
                {
                    Id = 2,
                    Name = "Demo User",
                    Email = "demo@kioncrm.com",
                    PasswordHash = "$2a$11$92IXUNpkjO0rOQ5byMi.Ye4oKoEa3Ro9llC/.og/at2uheWG/igi.",
                    Role = "demo"
                }
            );
        }
    }
}