﻿using System;
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
            Days readingDays = Days.Monday | Days.Satudary;

            Console.WriteLine($"reading days : {readingDays}");

            Console.Read();
        }
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
