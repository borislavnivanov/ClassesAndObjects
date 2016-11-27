using System;
using System.Linq;

namespace ArithmeticalExpressions
{
    class Aritmethics
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = Functions.SplitBySpace(input);
            int sum = Functions.Sum(numbers);
            Console.WriteLine(sum);
        }
    }

    public class Functions
    {
        internal static int[] SplitBySpace(string input)
        {
            int[] result = input.Split(' ').Select( n => Convert.ToInt32(n)).ToArray();
            return result;
        }
        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }

}
