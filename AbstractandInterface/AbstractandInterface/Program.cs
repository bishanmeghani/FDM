using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController uc = new UserController();
            uc.Login("LS","123");

            AdminController ac = new AdminController();
            ac.Login("HS", "456");

            SuperAdminController sc = new SuperAdminController();
            sc.Login("R2", "789");

            Console.ReadLine();
        }
    }
}
