using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingReportApp;
using ParkingReportApp.Models; // nếu ParkingLot nằm trong Models
using System.Linq;
using Effort; // dùng cho database in-memory
using System.Data.Common;


namespace ParkingReportApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddParkingLot_ShouldIncreaseCount()
        {
            // Arrange: Tạo in-memory database
            var connection = DbConnectionFactory.CreateTransient();
            var context = new AppDbContextEffort(connection);

            var lot = new ParkingLot
            {
                Name = "Bãi A",
                Capacity = 50,
                Address = "123 Lê Lợi, Q1"
            };

            // Act
            context.ParkingLots.Add(lot);
            context.SaveChanges();

            // Assert
            var result = context.ParkingLots.ToList();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Bãi A", result[0].Name);
        }
    }


    public class AppDbContextEffort : AppDbContext
    {
        public AppDbContextEffort(DbConnection connection)
            : base(connection, true)
        {
        }
    }
}
