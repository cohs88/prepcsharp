using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class EjemploFunc
    {
        /// <summary>
        /// esto es un action delegate, este no devuelve ningun valor es decir void
        /// </summary>
        Action<int, int> calc = (x, y) =>
        {
            Console.WriteLine(x + y);
        };

        public void DoAction()
        {
            calc(3, 4);
        }
    }
}
