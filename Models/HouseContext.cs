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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId = 1, Name = "Richmond" },
                new Region { RegionId = 2, Name = "Columbia" }
            );
            modelBuilder.Entity<Info>().HasData(
                new Info
                {
                    HouseId=1,
                    Address="3456 washtheroad rd",
                    BathCount=3,
                    BedRCount=4,
                    SqFt=12345,
                    Year=2019,
                    CodeIn="unkown in",
                    CodeOut="unkown out",
                    RegionId=1,
                    Price=12000
                }
            );
        }
    }
}

