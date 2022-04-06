using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        public string No { get; set; } 
        public int ProductCount { get; set; }   
        public int TotalAmount { get; set; }    
        public DateTime CreatedAt { get; set; } 

    }
}
