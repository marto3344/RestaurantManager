using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Order { get; set; }
        public decimal Bill { get; set; } = 0;
        public Table(string name)
        {
            this.Name = name;
        }
    }
}
