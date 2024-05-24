using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    public class UserData
    {
        public string ID { get; set; }
        public string userName { get; set; }
        public List<float> Scores { get; set; }

        public UserData()
        {
            Scores = new List<float>();
        }
    }
}
