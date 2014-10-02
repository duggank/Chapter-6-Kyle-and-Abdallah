using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {

        public static void DisplayMonogram(char first, char middle, char last)
        {

            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);

        }
        static void Main(string[] args)
        {
            char first = 'K', middle = 'R', last = 'D', first2 = 'A', middle2 = 'M', last2 = 'D';
            DisplayMonogram(first, middle, last);
            Console.WriteLine();
            DisplayMonogram(first2, middle2, last2);

        }
    }
}
