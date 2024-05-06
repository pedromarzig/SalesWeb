using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Saller saller)
        {
            Sallers.Add(saller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sallers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
