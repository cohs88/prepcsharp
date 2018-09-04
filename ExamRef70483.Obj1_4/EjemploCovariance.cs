using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    public class EjemploCovariance
    {
        public delegate TextWriter DelegadoCovariance();

        public StreamWriter MethodStream()
        {
            Console.Write("Stream");
            return null;
        }

        public StringWriter MethodString()
        {
            Console.Write("String");
            return null;
        }

        /// <summary>
        /// Por que ambos Stream y String writer heredan de TextWriter puedo usar DelegadoCovariance
        /// </summary>
        public void DoCovariance()
        {
            DelegadoCovariance del;
            del = MethodStream;
            del = MethodString;

            del();
        }
    }
}
