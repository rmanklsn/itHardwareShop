using System;

namespace Store
{
    public class Hardware
    {
        public string Title { get; }

        public int Id { get;  } 

        public Hardware (int id, string title)
        {
            Title = title;
            Id = id;
        }
    }
}
