using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Meal
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Meal(string name,decimal price)
        {
            this.Name= name;
            this.Price = price;
        }
    }
}
