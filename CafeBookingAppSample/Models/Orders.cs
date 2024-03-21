using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBookingAppSample.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public int ReservationId { get; set; }

        [ForeignKey("ReservationId")]
        public Reservations Reservations { get; set; }

        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Quantity { get; set; }

    }
}
