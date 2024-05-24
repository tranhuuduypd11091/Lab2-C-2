using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    public class Userdata
    {
        public int id;
        public string userName;
        public int level;
        public Userdata(int id, string userName, int level)
        {
            this.id = id;
            this.userName = userName;
            this.level = level;

        }
        public void ShowData()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Username: " + userName);
            Console.WriteLine("Level: " + level);
        }
        public void ShowData(string name, dynamic attribute)
        {
            Console.WriteLine(name + ": " + attribute);
        }
    }
}
