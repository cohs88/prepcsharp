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
            pub.OnChange += (sender, e) => Console.WriteLine("event raised: {0}", e.Value);
            pub.Raise();
        }
    }
}
