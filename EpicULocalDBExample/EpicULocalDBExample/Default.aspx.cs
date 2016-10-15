﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicULocalDBExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LocaldbEntities1 db = new LocaldbEntities1();

            var customers = db.Tables;

            string result = " ";

            foreach (var customer in customers)
            {
                result += "<p>" + customer.Name + "<p/>";
            }

            resultLabel.Text = result;
        }
    }
}