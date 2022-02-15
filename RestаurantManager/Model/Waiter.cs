using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Waiter
    {
        private string _waiterName;
        private string _waiterPassword;
        private int _id;
        public string WaiterName { get;set; }
        public string WaiterPassword { get;set; }
        public int Id { get;set;}
    }
}
