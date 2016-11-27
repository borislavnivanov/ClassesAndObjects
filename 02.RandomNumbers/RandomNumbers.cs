using System;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(100, 200);
                Console.WriteLine(a);
            }
        }
    }
}
