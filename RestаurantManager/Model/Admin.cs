using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Admin
    {
        private string _adminName;
        private string _adminPassword;
        private int _id;
        public string AdminName { get;set; }
        public string AdminPassword { get;set; }
        public int Id { get;set; }
    }
}
