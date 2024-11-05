using Castle.Core.Resource;
using HotelBookingAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
