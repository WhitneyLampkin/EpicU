using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CxId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid Tracking { get; set; }
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}