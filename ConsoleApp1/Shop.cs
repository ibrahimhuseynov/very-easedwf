using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop
    {
        public List<Order> orders = new List<Order>();
        List<Order> orders1;
        public void AddOrder()
        {
            orders.Add(new Order());
        }
        public void RemoveOrderByNo(string _no)
        {
            if (string.IsNullOrWhiteSpace(_no))
                throw new Exception("xeta");
            var result = orders.Find(x => x.No == _no);
            if (result == null)
            {
                throw new Exception("xeta bas verdi");
            }
            orders.Remove(result);
        }
        public List<Order> FilterOrderByPrice(int minPrice, int maxPrice)
        {
            return orders.FindAll(x => x.TotalAmount >= minPrice && x.TotalAmount <= maxPrice);
        }
        public double GetOrdersAvg(DateTime time)
        {
            var orders = orders1.FindAll(order => order.CreatedAt > time);
            double sum = 0;
            foreach (var order in orders1)
            {
                sum += order.TotalAmount;
            }
            return sum / orders1.Count;
        }
        public double GetOrdersAvg()
        {
            if (orders1.Count != 0)
            {
                double sum = 0;
                foreach (var order in orders1)
                {
                    sum += order.TotalAmount;
                }
                return sum / orders1.Count;
            }
            return 0;
        }
    }  
}
