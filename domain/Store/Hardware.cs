
using System;

namespace Store
{
    public class Hardware
    {
        public int Id { get; }
        public string Title { get; }

        public string Description { get; }

        public decimal Price { get; }

        public Hardware(int id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }
    }
}
