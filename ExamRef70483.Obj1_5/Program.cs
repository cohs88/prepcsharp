using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException e)
            {
                possibleException = ExceptionDispatchInfo.Capture(e);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }

            Console.Read();
        }

        private static int ReadAndParse()
        {
            string s = Console.ReadLine();
            int i = int.Parse(s);
            return i;
        }
    }
}
