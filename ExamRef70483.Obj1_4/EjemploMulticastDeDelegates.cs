using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj1_4
{
    /// <summary>
    /// When you assign a method to a delegate, the method signature does not have to match
    /// the delegate exactly.This is called covariance and contravariance.
    /// Covariance makes it possible that a method has a return type that is more derived than that defned in the delegate.
    /// Contravariance permits a method that has parameter types that are less derived than those in
    /// the delegate type.
    /// </summary>
    public class EjemploMulticastDeDelegates
    {
        public delegate void MyCustomDelegate();

        public void MethodOne()
        {
            Console.WriteLine("Method One");
        }

        public void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }

        public void Multicast()
        {
            MyCustomDelegate d = MethodOne;
            d += MethodTwo;

            Console.WriteLine($"Invocation Count : {d.GetInvocationList().GetLength(0)}");

            d();
        }
    }
}
