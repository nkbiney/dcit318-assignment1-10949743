using System;

namespace TriangleChecker
{
    class TriangleChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side: ");
            double side3 = double.Parse(Console.ReadLine());

            string triangleType = "";

            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            switch (triangleType)
            {
                case "Equilateral":
                    Console.WriteLine("The triangle is Equilateral.");
                    break;
                case "Isosceles":
                    Console.WriteLine("The triangle is Isosceles.");
                    break;
                case "Scalene":
                    Console.WriteLine("The triangle is Scalene.");
                    break;
            }
        }
    }
}
