using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConnectDbToFrontend.Models
{
    public partial class LaptopDbContext : DbContext
    {
        public LaptopDbContext()
        {
        }

        public LaptopDbContext(DbContextOptions<LaptopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Laptop> Laptop { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=LaptopDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.Property(e => e.LaptopId).HasColumnName("laptop_id");

                entity.Property(e => e.LaptopBrand)
                    .HasColumnName("laptop_brand")
                    .HasMaxLength(30);

                entity.Property(e => e.LaptopName)
                    .HasColumnName("laptop_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LaptopPrice)
                    .HasColumnName("laptop_price")
                    .HasMaxLength(30);

                entity.Property(e => e.LaptopSize)
                    .HasColumnName("laptop_size")
                    .HasMaxLength(10);

                entity.Property(e => e.LaptopStorage)
                    .HasColumnName("laptop_storage")
                    .HasMaxLength(30);
            });
        }
    }
}
