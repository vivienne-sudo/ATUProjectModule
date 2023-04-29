using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<Notification> Notifications { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<BankHoliday> BankHolidays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customize data types for SQLite
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(string))
                    {
                        // Use text data type for variable-length text fields
                        property.SetColumnType("text");
                    }
                }
            }
            // Seed admin role
            var adminRole = new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            modelBuilder.Entity<IdentityRole>().HasData(adminRole);
            modelBuilder.Entity<BankHoliday>().HasData(
                new BankHoliday { Id = 1, Date = new DateTime(2023, 1, 1), Name = "New Year's Day" },
                new BankHoliday { Id = 2, Date = new DateTime(2023, 3, 17), Name = "St. Patrick's Day" },
                new BankHoliday { Id = 3, Date = new DateTime(2023, 4, 7), Name = "Good Friday" },
                new BankHoliday { Id = 4, Date = new DateTime(2023, 4, 10), Name = "Easter Monday" },
                new BankHoliday { Id = 5, Date = new DateTime(2023, 5, 1), Name = "May Day" },
                new BankHoliday { Id = 6, Date = new DateTime(2023, 6, 5), Name = "June Bank Holiday" },
                new BankHoliday { Id = 7, Date = new DateTime(2023, 8, 7), Name = "August Bank Holiday" },
                new BankHoliday { Id = 8, Date = new DateTime(2023, 10, 30), Name = "October Bank Holiday" },
                new BankHoliday { Id = 9, Date = new DateTime(2023, 12, 25), Name = "Christmas Day" },
                new BankHoliday { Id = 10, Date = new DateTime(2023, 12, 26), Name = "St. Stephen's Day" }
            );
        }
    }
}
