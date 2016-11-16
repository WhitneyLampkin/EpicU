using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Customer
    {
        [Key]
        public int CxId { get; set; }
        public string CxFirstName { get; set; }
        public string CxLastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}