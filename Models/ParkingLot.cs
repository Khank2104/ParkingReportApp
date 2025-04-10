using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingReportApp.Models

{
    public class ParkingLot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Chỉ dòng này là tự tăng
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
