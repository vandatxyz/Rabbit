using Data.Entity;
using Data.Entity.Commons;
using Microsoft.EntityFrameworkCore;
using MassTransit;
using MassTransit.EntityFrameworkCoreIntegration;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<CarInfo> CarInfos { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<FileAttach> FileAttaches { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<OutboxMessage> OutboxMessages { get; set; }
        public DbSet<OutboxState> OutboxStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>()
                .HasMany(c => c.Districts)
                .WithOne(d => d.City)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.AddInboxStateEntity();
            modelBuilder.AddOutboxMessageEntity();
            modelBuilder.AddOutboxStateEntity();
        }
    }
}
