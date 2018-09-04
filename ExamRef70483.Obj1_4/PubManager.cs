using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class PubManager
    {
        public void CreateAndRaise()
        {
            Pub pub = new Pub();
            pub.OnChange += () => Console.WriteLine("event raised to method 1");
            pub.OnChange += () => Console.WriteLine("event raised to method 2");
            pub.Raise();
        }
    }
}
