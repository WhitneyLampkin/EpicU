using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class Main
    {
        public Main()
        {
            using (var conn = new SqlConnection("INSERT_CONNECTION_STRING"))
            {
                //Data is an IEnumerable of type dynamic; we could also use var
                //Also, this allows us to convert it to anything we want. i.e. ToList()
                IEnumerable<dynamic> data = conn.Query(@"
                    SELECT
                        ID,
                        Name 
                    FROM Customers
                   ");

                //Dapper automaps for us
                var name = data.First().Name;

                //If we used a different variable than 'Name' here, then we would need to set the Name in the 
                //SQL statement equal to the name inside of the database...???


            }
        }
    }
}