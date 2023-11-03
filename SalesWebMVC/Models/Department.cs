
using NuGet.Protocol.Plugins;
using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
