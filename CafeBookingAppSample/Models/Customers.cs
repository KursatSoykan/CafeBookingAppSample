using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBookingAppSample.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public DateTime? AddDate { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }
    
        [MaxLength(20)]
        public string SurName { get; set; }

        [MaxLength(40)]
        public string? Email { get; set; }

        [MaxLength(24)]
        public string? Phone { get; set; }

        [MaxLength(60)]
        public string? Address { get; set; }


    }
}
