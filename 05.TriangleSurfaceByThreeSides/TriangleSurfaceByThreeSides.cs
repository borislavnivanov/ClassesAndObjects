using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double sideA = int.Parse(Console.ReadLine());
        double sideB = int.Parse(Console.ReadLine());
        double sideC = int.Parse(Console.ReadLine());

        double result = Triangle.TriangleArea(sideA, sideB, sideC);
        Console.WriteLine("{0:F2}", result);
    }
}
static class Triangle
{
    public static double TriangleArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        double area = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));

        return area;
    }
}