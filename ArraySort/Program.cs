using System;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 8, 3, 6, 9, 17, 11 };
            Sort(arr, SortDirection.Asc);
        }
        private static void Sort(int[] arr, SortDirection sortDir)
        {
            Array.Sort<int>(arr, delegate (int m, int n)
            {
                return sortDir switch
                {
                    SortDirection.Asc => m - n,
                    SortDirection.Desc => n - m,
                    _ => m - n,
                };
            });
            foreach (int value in arr)
            {
                Console.WriteLine(value + " ");
            }
        }
        public enum SortDirection
        {
            Asc,
            Desc
        }
    }
}
