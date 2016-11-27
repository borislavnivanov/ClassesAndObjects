using System;


namespace _04.TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static void Main()
        {
            double sideLenght = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double result = (sideLenght * altitude) / 2;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
