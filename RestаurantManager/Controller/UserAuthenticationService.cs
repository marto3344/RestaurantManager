using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestаurantManager.Controller
{
    public static class UserAuthenticationService
    {
        public static bool CheckAdminLogin(string userName, string Password)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }
        public static bool CheckWaiterLogin(string userName, string Password)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }
    }
}
