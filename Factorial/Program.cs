using System;
using System.Collections.Generic;
using System.Linq;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer: ");
            var num  = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}! is:" + GetFactorial(num));
            Console.WriteLine("Displaying Factorial Tree ----->>");
            DisplayFactorialTree(num);
        }
        public static void DisplayFactorialTree(int num)
        {
            var factorials = Enumerable.Range(1, num)
                .Reverse()
                .Select((index) => new KeyValuePair<int, int>(index,
                                Enumerable.Range(1, index).Aggregate(1, (p, total) => p * total)));
            
            foreach(var factorial in factorials)
            {
                Console.WriteLine(String.Format("Factorial of {0}! = {1}\n", factorial.Key, factorial.Value));
            }
        }

        /// <summary>
        /// Calculates the factorial using Range then aggregate for the total
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetFactorial(int num)
        {
            return Enumerable.Range(1, num).Aggregate(1, (p, total) => p * total);
        }
    }
}
