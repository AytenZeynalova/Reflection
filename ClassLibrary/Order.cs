using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class Order
    {
        int _no;
        public Order()
        {
            _no++;
            No = _no;
        }
       
        public int No { get; }

        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
