using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class Pub
    {
        public Action OnChange { get; set; }
        public void Raise()
        {
            if (OnChange != null)
            {
                Console.WriteLine($"Invocation list: {OnChange.GetInvocationList().GetLength(0)}");
                OnChange();
            }
        }
    }
}
