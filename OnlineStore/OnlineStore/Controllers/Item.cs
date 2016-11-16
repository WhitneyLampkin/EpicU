using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Controllers
{
    public class Item
    {
        public Product product = new Product();
        public int quantity;

        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}