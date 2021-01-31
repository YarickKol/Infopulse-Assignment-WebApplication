using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }

        public int OrdersCount { get; set; }

        public decimal TotalOrderCost { get; set; }

    }
}
