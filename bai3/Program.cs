using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<float> listdata = new List<float>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };


            UserData user = new UserData()
            {
                ID = "2910",
                userName = "tranhuuduy",
                Scores = listdata
            };


            Console.WriteLine("ID: " + user.ID);
            Console.WriteLine("UserName: " + user.userName);
            Console.WriteLine("Scores: ");
            foreach (float score in user.Scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}