using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bài_1
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Bai 1a");
            var x = 10;
            void a()
            {
                Console.WriteLine("X: " + x);
            }
            a();
            Console.WriteLine();

            Console.WriteLine("bai 1b:");
            void getDetail(dynamic value)
            {
                Console.WriteLine("Value: " + value);
            }
            void b()
            {
                getDetail(10);
                getDetail("Game");
            }
            b();
            Console.WriteLine();

            Console.WriteLine("Bai 1c:");
            Userdata userdata = new Userdata(2910, "abcd", 50);
            userdata.ShowData("Level", userdata.level);
            userdata.ShowData("ID", userdata.id);
            userdata.ShowData("username", userdata.userName);
            Console.WriteLine();
            return 0;
        }

    }
}