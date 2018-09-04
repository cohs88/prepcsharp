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
            pub.OnChange += (sender, e) => Console.WriteLine("susbcriber 1 called");
            pub.OnChange += (sender, e) => { throw new Exception(); };
            pub.OnChange += (sender, e) => Console.WriteLine("susbcriber 3 called");


            try
            {
                pub.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"Exceptions occurred : {ex.InnerExceptions.Count}");
            }
        }
    }
}
