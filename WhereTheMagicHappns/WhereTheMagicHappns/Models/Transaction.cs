using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhereTheMagicHappns.Models
{
    public class Transaction
    {
        public string Agency { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public double Value { get; set; }
    }
}