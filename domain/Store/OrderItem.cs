using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class OrderItem
    {
        public int HardwareId { get; }

        public int Count { get; }

        public decimal Price { get; }

        public OrderItem(int hardwareId, int count, decimal price) 
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException("Count must be greater then zero");
            
            
            HardwareId = hardwareId; 
            Count = count; 
            Price = price;                                                      
           
        }
    }
}
