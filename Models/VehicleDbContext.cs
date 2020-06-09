using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Capstone6_CarDealership.Models
{
    public partial class VehicleDbContext : DbContext
    {
        public VehicleDbContext()
        {
        }

        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=VehicleDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Color).HasMaxLength(40);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Make).HasMaxLength(40);

                entity.Property(e => e.Model).HasMaxLength(40);

                entity.Property(e => e.Year).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
