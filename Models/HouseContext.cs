using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smtih_Midterm.Models
{
    public class HouseContext : DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Info> Infos { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Photos> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId = 1, Name = "Richmond" },
                new Region { RegionId = 2, Name = "Columbia" }
            );
            modelBuilder.Entity<Photos>().HasData(
                new Photos { PhotoFilter=1,Pic1="bathroom1.jpg",Pic2="bedroom1.jpg",Pic3="kitchen1.jpg"},
                new Photos { PhotoFilter=2,Pic1="bathroom2.jpg", Pic2 = "bedroom2.jpg", Pic3 = "kitchen2.jpg" }
            );
            modelBuilder.Entity<Info>().HasData(
                new Info
                {
                    HouseId=1,
                    PhotoFilter=1,
                    Address= "4340 Peach Orchard Rd, Hephzibah, GA 30815",
                    BathCount=3,
                    BedRCount=7,
                    SqFt= 5726,
                    Year=1929,

                    Heating="Forced air, Heat pump",
                    AC="Central",

                    CodeOut="out1.jpg",
                    RegionId=1,
                    Price=325000
                },
                new Info
                {
                    HouseId = 2,
                    PhotoFilter=2,
                    Address = "1105 Fawn Forest Rd, Grovetown, GA",
                    BathCount = 3,
                    BedRCount = 5,
                    SqFt = 3371,
                    Year = 2018,

                    Heating = "Heat pump",
                    AC = "Central",

                    CodeOut = "out2.jpg",
                    RegionId = 2,
                    Price = 300000
                }
            );
        }
    }
}

