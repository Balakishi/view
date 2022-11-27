using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace view
{
    public class Connection
    {
          public static string GetConnect
            {
                get { return "Data Source =HOME-PC\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True"; }
            }
    }
}