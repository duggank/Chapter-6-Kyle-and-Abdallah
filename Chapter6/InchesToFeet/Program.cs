using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches = 67;
            InchesToFeet(inches);
            InchesToYards(inches);
        }

        public static void InchesToFeet(int inches)
        {
            int feet = inches / 12;
            int remain = inches % 12;
            Console.WriteLine("{0} inches = {1} feet and {2} inches.", inches, feet, remain);
        }

        public static void InchesToYards(int inches)
        {
            int feet = inches / 12;
            int yards = feet / 3;
            int rfeet = feet - 3;
            int remain = inches % 12;
            Console.WriteLine("{0} inches = {1} yard(s), {2} feet, and {3} inches.", inches, yards, rfeet, remain);
        }
    }
}
