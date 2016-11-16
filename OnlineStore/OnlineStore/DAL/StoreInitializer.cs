using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.DAL
{
    public class StoreInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext db)
        {
            var customers = new List<Customer>
            {
                new Customer {
                    CxId = 1,
                    CxFirstName = "Whitney",
                    CxLastName = "Lampkin",
                    AddressLine1 = "123 Main St.",
                    AddressLine2 = "Apt 1",
                    City = "Dallas",
                    State = "TX",
                    ZipCode = 75213
                },

                new Customer
                {
                    CxId = 2,
                    CxFirstName = "Regis",
                    CxLastName = "Davis Jr.",
                    AddressLine1 = "123 First St.",
                    AddressLine2 = "Apt 1",
                    City = "Ft. Worth",
                    State = "TX",
                    ZipCode = 75968
                },

                new Customer
                {
                    CxId = 3,
                    CxFirstName = "Kai",
                    CxLastName = "Lymore",
                    AddressLine1 = "123 Second St.",
                    AddressLine2 = "Apt 1",
                    City = "New York",
                    State = "NY",
                    ZipCode = 15324
                },

                new Customer
                {
                    CxId = 4,
                    CxFirstName = "Felicia",
                    CxLastName = "Daivs",
                    AddressLine1 = "123 Third St.",
                    AddressLine2 = "Apt 1",
                    City = "Orlando",
                    State = "FL",
                    ZipCode = 34856
                },

                new Customer
                {
                    CxId = 5,
                    CxFirstName = "Dorothy",
                    CxLastName = "Shepherd",
                    AddressLine1 = "123 Fourth St.",
                    AddressLine2 = "Apt 1",
                    City = "Hollywood",
                    State = "CA",
                    ZipCode = 96451
                }
            };
            customers.ForEach(c => db.Customers.Add(c));
            db.SaveChanges();

            var orders = new List<Order>
            {
                new Order
                {
                    OrderId = 11151601,
                    OrderDate = DateTime.Parse("2016-01-15"),
                    CxId = 1,
                    Products = new List<Product> { },
                    Subtotal = 90.00,
                    Tax = 4.00,
                    Total = 94.00
                },

                new Order
                {
                    OrderId = 11151602,
                    OrderDate = DateTime.Parse("2016-11-01"),
                    CxId = 2,
                    Products = new List<Product> { },
                    Subtotal = 25.00,
                    Tax = 1.75,
                    Total = 26.75
                }
            };
            orders.ForEach(o => db.Orders.Add(o));
            db.SaveChanges();

            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Category = "<img src= \"http://www.polyvore.com/cgi/img-thing?.out=jpg&size=l&tid=3024702 \" />",
                    Name = "Sunglasses",
                    Price = 15.00,
                    Quantity = 25
                },

                new Product
                {
                    ProductId = 2,
                    Category = "<img src= \"http://www.polyvore.com/cgi/img-thing?.out=jpg&size=l&tid=3024702 \" />",
                    Name = "Evening Dress",
                    Price = 145.00,
                    Quantity = 11
                },

                new Product
                {
                    ProductId = 3,
                    Category = "<img src= \"http://www.polyvore.com/cgi/img-thing?.out=jpg&size=l&tid=126767993 \" />",
                    Name = "Denim Jeans",
                    Price = 95.00,
                    Quantity = 33,
                },

                new Product
                {
                    ProductId = 4,
                    Category = "<img src= \"https://ae01.alicdn.com/kf/HTB1DplZNpXXXXamaXXXq6xXFXXXB/Modern-Spring-Autumn-and-Winter-Womens-Long-Sleeve-Printed-Pullover-casual-Sweatshirts-Blouse-Tops-Cotton-Eiffel.jpg_220x220.jpg \" />",
                    Name = "Paris Sweatshirt",
                    Price = 45.00,
                    Quantity = 17,
                },

                new Product
                {
                    ProductId = 5,
                    Category = "<img src= \"http://www.polyvore.com/cgi/img-thing?.out=jpg&size=l&tid=3024702 \" />",
                    Name = "Women's Blouse",
                    Price = 60.00,
                    Quantity = 6,
                }
            };
            products.ForEach(p => db.Products.Add(p));
            db.SaveChanges();
        }
    }
}