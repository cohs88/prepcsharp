using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class EjemploContravariance
    {
        public delegate void DelegadoContravariance(StreamWriter streamWriter);
        void DoSomething(TextWriter textWriter)
        {
            Console.WriteLine("Ejecutando DoSomething(TextWriter tx)");
        }

        public void DoContravariance()
        {
            DelegadoContravariance delegado = DoSomething;

            delegado(new StreamWriter("important.txt"));
        }
    }
}
