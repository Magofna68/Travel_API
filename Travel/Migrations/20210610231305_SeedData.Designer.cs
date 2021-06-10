﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20210610231305_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("Recommended")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "A big tall natural momument",
                            Location = "NYC",
                            Name = "Mt. Everest",
                            Rating = 2,
                            Recommended = true
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "Large 'man made' structure",
                            Location = "Egypt",
                            Name = "Great Pyramid",
                            Rating = 4,
                            Recommended = false
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "Amazing",
                            Location = "New York",
                            Name = "Niagara Falls",
                            Rating = 5,
                            Recommended = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}