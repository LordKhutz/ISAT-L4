namespace Data
{
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class BmiContext : DbContext
    {
        public BmiContext(DbContextOptions<BmiContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasKey(_ => _.Id);
            modelBuilder.Entity<Trainer>()
                .HasKey(_ => _.Id);
            modelBuilder.Entity<TrainerSalary>()
                .HasKey(_ => _.Id);
            modelBuilder.Entity<TrainingSession>()
                .HasKey(_ => _.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
