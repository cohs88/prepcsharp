using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatorOr();
            //OrShortCircuit();
            //XorOperator();
            //NullCoalescingOperator();
            //ForLoopSinParametros();
            //GotoStatements();

            Console.Read();
        }

        #region Jump Statements
        private static void GotoStatements()
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

            customLabel:
            Console.WriteLine($"Desde el custom label x = {x}");
        }
        #endregion

        #region Loops
        private static void ForLoopSinParametros()
        {
            int x = 1;
            for (; ; )
            {
                if (x <= 10)
                    Console.WriteLine($"x = {x}");
                else
                {
                    Console.WriteLine("bye");
                    break;
                }

                x++;
            }
        }
        #endregion

        #region Making Decisions

        /// <summary>
        /// Null operator retorn el lado izquierdo si no es null sino el lado derecho
        /// </summary>
        private static void NullCoalescingOperator()
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine($"y = {y}");
        }
        #endregion

        #region Operators
        /// <summary>
        /// Exactament 1 de los operandos es Verdadero
        /// </summary>
        private static void XorOperator()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
        }

        private static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
            Console.WriteLine(result);
        }

        private static bool GetY()
        {
            Console.WriteLine("This method does not get called");
            return true;
        }

        private static void OperatorOr()
        {
            bool x = true;
            bool y = false;

            bool result = x || y;
            Console.WriteLine(result);
        }
        #endregion
    }
}
