using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBookingAppSample.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

    }
}
