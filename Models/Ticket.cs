using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReportApp.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public DateTime CheckInTime { get; set; } // BỔ SUNG DÒNG NÀY

        public int ParkingLotId { get; set; }
        public virtual ParkingLot ParkingLot { get; set; }
    }
}
