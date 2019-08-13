using System;
using BM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BM.EF
{
    public class BMContext : DbContext
    {
        public BMContext()
        {
        }

        public BMContext(DbContextOptions<BMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseNpgsqlIdentityAlwaysColumn();

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("CREATED_TIME")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("character(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("character(50)");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasColumnType("character(100)");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasColumnType("character(50)");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("UPDATED_TIME")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasColumnType("character(12)");
            });
        }
    }
}
