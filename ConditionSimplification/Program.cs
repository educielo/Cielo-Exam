using System;

namespace ConditionSimplification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zero c: ");
            Console.WriteLine("Simplified: "+ Simplified(1,1,0));
            Console.WriteLine("Original: " + Original(1, 1, 0));

            Console.WriteLine("All > 0: ");
            Console.WriteLine("Simplified: " + Simplified(1, 1, 1));
            Console.WriteLine("Original: " + Original(1, 1, 1));

            Console.WriteLine("Zero a: ");
            Console.WriteLine("Simplified: " + Simplified(0, 1, 1));
            Console.WriteLine("Original: " + Original(0, 1, 1));

            Console.WriteLine("Zero b: ");
            Console.WriteLine("Simplified: " + Simplified(1, 0, 1));
            Console.WriteLine("Original: " + Original(1, 0, 1));

            Console.WriteLine("Zero a & b: ");
            Console.WriteLine("Simplified: " + Simplified(0, 0, 1));
            Console.WriteLine("Original: " + Original(0, 0, 1));
        }
        public static int Simplified(int a, int b, int c)
        {
            return a <= 0 && b <= 0 || c <= 0 ? 0 : a + b + c;
        }

        public static int Original(int a, int b, int c)
        {
            if (((a > 0 && b > 0) || (a > 0 && c > 0) || (b > 0 && c > 0)) && !(c <= 0))
            { return a + b + c; }
            else { return 0; }
        }
    }
}
