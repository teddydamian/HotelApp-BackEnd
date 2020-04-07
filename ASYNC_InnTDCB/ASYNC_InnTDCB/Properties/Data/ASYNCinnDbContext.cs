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

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    ID = 1,
                    Name = "SeattleWA Hotel",
                    StreetAddress = "123 Seattle St.",
                    State = "Washington",
                    City = "Seattle",
                    Phone = 2061234567,
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Denver Hotel",
                    StreetAddress = "123 Colorado St.",
                    State = "Colorado",
                    City = "Denver",
                    Phone = 2062222222,
                },
                new Hotel
                {
                    ID = 3,
                    Name = "Portland Hotel",
                    StreetAddress = "123 Portland St.",
                    State = "Oregon",
                    City = "Portland",
                    Phone = 2063333333,
                },
                new Hotel
                {
                    ID = 4,
                    Name = "Kona Hotel",
                    StreetAddress = "123 Kona St.",
                    State = "Hawaii",
                    City = "Kona",
                    Phone = 2064444444,
                },
                new Hotel
                {
                    ID = 5,
                    Name = "San Diego Hotel",
                    StreetAddress = "123 Diego St.",
                    State = "California",
                    City = "San Diego",
                    Phone = 2065555555,
                }
              );

            modelBuilder.Entity<Room>().HasData(

                new Room
                {
                    ID = 1,
                    Name = "Teemo",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 2,
                    Name = "Lux",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 3,
                    Name = "Jinx",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 4,
                    Name = "Garen",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 5,
                    Name = "Hecarim",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 6,
                    Name = "Ashe",
                    Layout = Layout.Studio
                }
                );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Coffee Maker"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Full Kitchen"
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Sea View"
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Sky View"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Backyard"
                }
                );

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
