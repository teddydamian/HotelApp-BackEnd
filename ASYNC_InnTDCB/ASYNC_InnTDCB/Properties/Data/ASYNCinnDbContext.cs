using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_InnTDCB.Models;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Properties.Data
{
    public class ASYNCinnDbContext : DbContext
    {
        /// <summary>
        /// Assigning primary key to  HotelRoom and RoomAmenities
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(x => new { x.HotelID, x.RoomNumber });
            modelBuilder.Entity<RoomAmenities>().HasKey(x => new { x.RoomID, x.AmenitiesID });
        }

        public ASYNCinnDbContext(DbContextOptions<ASYNCinnDbContext> options) :base(options)
        {

        }

        /// <summary>
        /// Schema for Database to create a table for each Entity
        /// </summary>
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }


    }
}
