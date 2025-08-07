using Microsoft.EntityFrameworkCore;
using AndysApp.Models;

namespace AndysApp.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
