using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class Shop
    {
       public  List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double sum = 0;
            int count=0;
            
            foreach (var item in Orders)
            {
                sum += item.TotalAmount;
                count++;
            }return sum/count;
        }
        
        public  double GetOrdersAvg(DateTime dateTime)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in Orders)
            {
                if (dateTime < item.CreatedAt)
                {
                    count++;
                    sum += item.TotalAmount;
                }
            }return sum / count;

        }
        public List<Order> RemoveOrderByNo(int no)
        {
            List<Order> romovedElements = new List<Order>();
            foreach (var item in Orders)
            {
                if (item.No != no)
                {
                    romovedElements.Add(item);
                }
            }return romovedElements;
        }

        public List<Order> FilterOrderByPrice(double minPrice, double maxPrice)
        {
            List<Order> FilteredListByPrice = new List<Order>();
            foreach (var item in Orders)
            {
                if(item.TotalAmount>minPrice && item.TotalAmount < maxPrice)
                {
                    FilteredListByPrice.Add(item);
                }
            }return FilteredListByPrice;
        }
    }
}
