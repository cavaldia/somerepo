﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClass
{
    public class Time
    {
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;

        public void DisplayCurrentTime()
        {
            Console.WriteLine("Metoda DisplayCurrentTime");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Time t = new Time(); //making new object or however they call it
            t.DisplayCurrentTime();

            Console.ReadKey(); //just because the console is stupid 
        }
    }
}