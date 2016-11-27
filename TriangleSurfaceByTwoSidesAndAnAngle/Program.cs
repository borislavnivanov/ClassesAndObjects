using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleC = double.Parse(Console.ReadLine());

            double area = Triangle.TriangleArea(sideA, sideB, angleC);
            Console.WriteLine("{0:F2}", area);
        }
    }
    public class Triangle
    {
        public static double TriangleArea(double a, double b, double c)
        {
            c = (Math.PI / 180) * c;
            double result = (a * b * (Math.Sin(c))) / 2;
            return result;
        }
    }
}
