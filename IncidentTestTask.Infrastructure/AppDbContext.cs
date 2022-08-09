using IncidentTestTask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IncidentTestTask.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(e => e.Name).IsUnique();

            modelBuilder.Entity<Contact>().HasIndex(e => e.Email).IsUnique();
        }
    }
}