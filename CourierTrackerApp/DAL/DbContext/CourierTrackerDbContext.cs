
using CourierTrackerApp.Models;
using System.Data.Entity;


namespace CourierTrackerApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Courier> Couriers { get; set; }
    }
}