using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Model
{
    public class Admin
    {       
        public string AdminName { get;set; }
        public string AdminPassword { get;set; }
        public int Id { get;set; }
        public Admin(int id, string adminName, string adminPassword)
        {
            this.Id = id;
            this.AdminName = adminName;
            this.AdminPassword = adminPassword;

        }
    }
}
