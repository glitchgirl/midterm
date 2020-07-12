﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smtih_Midterm.Models;

namespace Smtih_Midterm.Migrations
{
    [DbContext(typeof(HouseContext))]
    partial class HouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Smtih_Midterm.Models.Info", b =>
                {
                    b.Property<int>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BathCount")
                        .HasColumnType("int");

                    b.Property<int>("BedRCount")
                        .HasColumnType("int");

                    b.Property<string>("CodeOut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Heating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhotoFilter")
                        .HasColumnType("int");

                    b.Property<int?>("PhotosPhotoFilter")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("SqFt")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("HouseId");

                    b.HasIndex("PhotosPhotoFilter");

                    b.HasIndex("RegionId");

                    b.ToTable("Infos");

                    b.HasData(
                        new
                        {
                            HouseId = 1,
                            AC = "Central",
                            Address = "4340 Peach Orchard Rd, Hephzibah, GA 30815",
                            BathCount = 3,
                            BedRCount = 7,
                            CodeOut = "out1.jpg",
                            Heating = "Forced air, Heat pump",
                            PhotoFilter = 1,
                            Price = 325000,
                            RegionId = 1,
                            SqFt = 5726,
                            Year = 1929
                        },
                        new
                        {
                            HouseId = 2,
                            AC = "Central",
                            Address = "1105 Fawn Forest Rd, Grovetown, GA",
                            BathCount = 3,
                            BedRCount = 5,
                            CodeOut = "out2.jpg",
                            Heating = "Heat pump",
                            PhotoFilter = 2,
                            Price = 300000,
                            RegionId = 2,
                            SqFt = 3371,
                            Year = 2018
                        });
                });

            modelBuilder.Entity("Smtih_Midterm.Models.Photos", b =>
                {
                    b.Property<int>("PhotoFilter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pic1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pic2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pic3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoFilter");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            PhotoFilter = 1,
                            Pic1 = "bathroom1.jpg",
                            Pic2 = "bedroom1.jpg",
                            Pic3 = "kitchen1.jpg"
                        },
                        new
                        {
                            PhotoFilter = 2,
                            Pic1 = "bathroom2.jpg",
                            Pic2 = "bedroom2.jpg",
                            Pic3 = "kitchen2.jpg"
                        });
                });

            modelBuilder.Entity("Smtih_Midterm.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            RegionId = 1,
                            Name = "Richmond"
                        },
                        new
                        {
                            RegionId = 2,
                            Name = "Columbia"
                        });
                });

            modelBuilder.Entity("Smtih_Midterm.Models.Info", b =>
                {
                    b.HasOne("Smtih_Midterm.Models.Photos", "Photos")
                        .WithMany()
                        .HasForeignKey("PhotosPhotoFilter");

                    b.HasOne("Smtih_Midterm.Models.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
