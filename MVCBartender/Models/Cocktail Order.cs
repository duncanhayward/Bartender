using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCBartender.Models
{
    public class Cocktail_Order : ApiController
    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int DrinkID{ get; set; }

        public virtual ICollection<Drink_Menu> Orders {get; set;}
    }
}