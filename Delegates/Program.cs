using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate bool CheckMethod(int number);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            var numberString = Console.ReadLine();
            var number = int.Parse(numberString);

            Console.WriteLine("Enter operand:");
            var operand = Console.ReadLine();

            int i;
            CheckMethod method;
            Func<int, bool> method2;
            if (operand == "e")
            {
                Console.WriteLine("IsEven:");
                method = IsEven;
                method2 = IsEven;
            }
            else
            {
                Console.WriteLine("IsOdd:");
                method = IsOdd;
                method2 = IsOdd;
            }
            
            Console.WriteLine(method(number));
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}