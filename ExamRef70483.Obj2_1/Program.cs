using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRef70483.Obj2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleEnumWithFlags();
            Point point = new Point(1, 10);


            Console.Read();
        }

        private static void ExampleEnumWithFlags()
        {
            Days readingDays = Days.Monday | Days.Satudary;

            Console.WriteLine($"reading days : {readingDays}");
        }
    }

    /// <summary>
    /// An Struct is a Value type and its stored in the Stack
    /// It cannot be used for inheritance hierarchy
    /// all value types derives from System.ValueType
    /// </summary>
    public struct Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        /// <summary>
        /// Cannot create empty Constructor for an Struct
        /// </summary>
        //public Point()
        //{

        //}
    }

    [Flags]
    enum Days
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Satudary = 0x40
    }
    
}
