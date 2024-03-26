
using System;

namespace Store
{
    public class Hardware
    {
        public int Id { get; }
        public string Title { get; }

        public Hardware(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
