using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCBartender.Models
{
    public class Customer : ApiController
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}