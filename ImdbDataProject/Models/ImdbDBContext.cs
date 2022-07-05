using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ImdbDataProject.Models
{
    public partial class ImdbDBContext : DbContext
    {
        public ImdbDBContext()
        {
        }

        public ImdbDBContext(DbContextOptions<ImdbDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblmovie> Tblmovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //Connection String
                optionsBuilder.UseSqlServer("Server=MONSTER\\SQLEXPRESS;Database=ImdbDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblmovie>(entity =>
            {
                entity.ToTable("TBLMovies");

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Stars)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Writer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
