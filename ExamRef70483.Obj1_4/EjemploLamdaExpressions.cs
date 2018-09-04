using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class EjemploLamdaExpressions
    {
        public delegate int Calculate(int x, int y);

        /// <summary>
        /// uso de expresiones lamda para crear un delegate
        /// </summary>
        public void DoLamda()
        {
            Calculate calc = (x, y) => x + y;// esto es un anonymous functions por que no tiene nombre
            Console.WriteLine(calc(3,4));

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
