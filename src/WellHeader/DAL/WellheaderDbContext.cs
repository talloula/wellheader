using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WellHeader.DAL;

public partial class WellheaderDbContext : DbContext
{
    public WellheaderDbContext()
    {
    }

    public WellheaderDbContext(DbContextOptions<WellheaderDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Well> Wells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Well>(entity =>
        {
            entity.HasKey(e => e.WellId).HasName("PK__Wells__E955CC1C76D95E60");

            entity.Property(e => e.WellId).HasColumnName("WellID");
            entity.Property(e => e.WellName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
