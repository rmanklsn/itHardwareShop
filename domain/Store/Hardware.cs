
using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Hardware
    {
        public int Id { get; }

        public string ID_N {  get; }
        public string Title { get; }

        public string Description { get; }

        public decimal Price { get; }

        public Hardware(int id, string id_n, string title, string description, decimal price)
        {
            Id = id;
            ID_N = id_n;
            Title = title;
            Description = description;
            Price = price;
        }

        internal static bool isID_N(string s) 
        {
            if (s == null)
                return false;
            s = s.Replace("-", "").Replace(" ", "").ToUpper();

            return Regex.IsMatch(s, @"^ID_N\d{10}(\d{3})?$");
        }
    }
}
