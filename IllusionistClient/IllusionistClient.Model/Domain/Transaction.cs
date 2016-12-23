using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllusionistClient.Model.Domain
{
    public class Transaction
    {
        public string Agency { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Value { get; set; }
    }
}
