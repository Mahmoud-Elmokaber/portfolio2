using Microsoft.EntityFrameworkCore;

namespace portfolio2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<PersonalInfo> personalInfo { get; set; }
        public DbSet<ContactInfo> contactInfo { get; set; }
        public DbSet<Technology> technologies { get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Form> forms{ get; set; }
        public DbSet<Link> links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>()
            .HasMany(p => p.technologies)
            .WithMany(t => t.Projects);

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
