using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square
{
    class Program
    {
        public static void SwapSquare(ref int user)
        {
            user *= user;
        }

        static void Main(string[] args)
        {
            Console.Write("How art thou? Good? Okay... Enter a number: ");
            int user = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The original value is: {0}", user);
            SwapSquare(ref user);

            Console.WriteLine("The altered value is: {0}", user);
            Console.WriteLine();
            Console.WriteLine("So what we did was create a method to square your value and we printed it");
            Console.Write(" and stuff... WITH REFERENCE! :D");
        }
    }
}
