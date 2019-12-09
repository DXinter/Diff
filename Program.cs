using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = { 1, 2, 2, 2, 3 };
            int[] second = { 2 };
            IEnumerable<int> result = Diff(first, second);

            Console.WriteLine("Разница: ");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        public static IEnumerable<int> Diff(int[] first, int[] second)
        {
            IEnumerable<int> result = first.Except(second);
            return result;
           
        }
    }
}
