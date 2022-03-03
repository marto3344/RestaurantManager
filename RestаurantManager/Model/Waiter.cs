using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Waiter
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public Waiter(int id, string name, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
        }
    }
}
