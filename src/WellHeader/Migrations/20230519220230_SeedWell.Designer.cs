﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WellHeader.DAL;

#nullable disable

namespace WellHeader.Migrations
{
    [DbContext(typeof(WellheaderDbContext))]
    [Migration("20230519220230_SeedWell")]
    partial class SeedWell
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WellHeader.Entities.Well", b =>
                {
                    b.Property<int>("WellID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WellID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WellID"));

                    b.Property<string>("APINumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldID")
                        .HasColumnType("int");

                    b.Property<double?>("Lat")
                        .HasColumnType("float");

                    b.Property<double?>("Long")
                        .HasColumnType("float");

                    b.Property<string>("WellName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("WellID")
                        .HasName("PK__Wells__E955CC1C76D95E60");

                    b.ToTable("Wells");

                    b.HasData(
                        new
                        {
                            WellID = 1,
                            APINumber = "42000011110000",
                            FieldID = 0,
                            WellName = "My Sample Well #1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}