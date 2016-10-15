using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car());
            cars.Add(new Car());

            cars.OrderBy(a => Guid.NewGuid());

            resultLabel.Text = cars.ToString();
            
        }

        public class Car
        {
            public Guid CarId { get; set; }

            public Car()
            {
                CarId = Guid.NewGuid();
            }
        }
    }
}