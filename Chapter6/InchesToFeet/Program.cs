using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        public static void InchesToFeet(int inches, int feet, int remain)
        {
            feet = inches / 12;
            remain = inches % 12;
        }

        static void Main(string[] args)
        {
        }
    }
}
