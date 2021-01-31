using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Status { get; set; }

        public decimal TotalCost { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }

        public virtual int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
