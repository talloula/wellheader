using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WellHeader.Entities;

//to enable migrations, issue this in NPM console:  -ContextTypeName WellHeader.DAL.WellHeaderDBContext
namespace WellHeader.DAL;

public partial class WellheaderDbContext : DbContext
{
    public WellheaderDbContext()
    {
    }

    public WellheaderDbContext(DbContextOptions<WellheaderDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
        Database.Migrate();
    }

    public virtual DbSet<Well> Wells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Well>(entity =>
        {

            entity.Property(e => e.WellName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Seed();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
