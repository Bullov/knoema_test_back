using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllData> AllData { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubjectCode).IsUnicode(false);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_all_data_countries");

                entity.HasOne(d => d.SubjectCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.SubjectCode)
                    .HasConstraintName("FK_all_data_subjects");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
