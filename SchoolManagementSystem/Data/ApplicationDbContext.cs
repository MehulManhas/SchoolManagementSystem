using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models.Entities;

namespace SchoolManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
            .HasKey(t => t.Guid);

            base.OnModelCreating(modelBuilder);
        }
    }
}
