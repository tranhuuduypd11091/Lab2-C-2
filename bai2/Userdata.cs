using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    public class Userdata
    {
        public void bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = "duyth ",
                isplaying = "5v5",
                bag = new
                {
                    skins = 925,
                    cups = 8,
                }
            };

            Action logUserInfo = delegate
            {
                Console.WriteLine("ID: " + userInfp.id);
                Console.WriteLine("Name: " + userInfp.name);
                Console.WriteLine("Dang choi: " + userInfp.isplaying);
                Console.WriteLine("Skins: " + userInfp.bag.skins);
                Console.WriteLine("Cup: " + userInfp.bag.cups);
            };

            logUserInfo();
        }
        public void bai2b()
        {
            int x = 10;
            int y = 20;
            Action<int> AnonymousMethod = delegate (int z)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum: " + sum);
                Console.WriteLine("sub: " + sub);
            };
            AnonymousMethod(5);
        }
    }
}