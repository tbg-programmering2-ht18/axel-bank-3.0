using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyabanken_3._0
{
    class Customer
    {
        public string name { get; set; }
        public int balance { get; set; }
        public string customerInfo()
        {
            return this.name;
        }
    }
}