
using System.Collections.Generic;


namespace Store
{
    public class Order
    {
        public int Id { get; }

        private List<OrderItem> items;

        public IReadOnlyCollection<OrderItem> Items
        {
            get { return items; }                                                                                                                                                                                                                                                               
        }

        public int TotalCount 
        {
            get { return items.Sum(items => items.Count); }
        }

        public decimal TotalPrice
        {
            get { return items.Sum(items => items.Price * items.Count); }
        }

        public Order(int id, IEnumerable<OrderItem> items) 
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));
            
            Id = id;

            this.items = new List<OrderItem>(items);
        }

        public void AddItem(Hardware hardware, int count)
        {
            if (hardware == null)
                throw new ArgumentNullException(nameof(hardware));
            var item = items.SingleOrDefault(x => x.HardwareId == hardware.Id);

            if (item == null)
            {
                items.Add(new OrderItem(hardware.Id, count, hardware.Price));
            }
            else
            {
                items.Remove(item);
                items.Add(new OrderItem(hardware.Id, item.Count + count, hardware.Price));
            }
        }
    }
}
