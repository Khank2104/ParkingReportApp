using System.Data.Common;
using System.Data.Entity;
using ParkingReportApp.Models;

namespace ParkingReportApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }

        public AppDbContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
        }

        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}