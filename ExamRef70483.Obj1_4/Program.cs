using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //UnderstangingDelegates understangingDelegates = new UnderstangingDelegates();

            //understangingDelegates.UseDelegate();

            //EjemploMulticastDeDelegates ejemplo = new EjemploMulticastDeDelegates();
            //ejemplo.Multicast();


            //EjemploCovariance ejemplo = new EjemploCovariance();
            //ejemplo.DoCovariance();

            //EjemploContravariance ejemplo = new EjemploContravariance();
            //ejemplo.DoContravariance();

            //EjemploLamdaExpressions ejemplo = new EjemploLamdaExpressions();
            //ejemplo.DoLamda();

            //EjemploFunc ejemplo = new EjemploFunc();
            //ejemplo.DoAction();

            PubManager pubManager = new PubManager();
            pubManager.CreateAndRaise();

            Console.Read();
        }
    }
}
