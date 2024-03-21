using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBookingAppSample.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public int CustomerId { get; set; }
        
        [ForeignKey("CustomersId")]
        public Customers Customers { get; set; }
        public DateTime? ReservationDate { get; set; }
    }
}
