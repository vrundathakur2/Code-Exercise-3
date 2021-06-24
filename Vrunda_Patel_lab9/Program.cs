using System;

namespace Vrunda_Patel_lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a side of the cube:");

            //Creating variable to hold the values
            double Side, Radius;


            while (true)
            {
                bool Flag = double.TryParse(Console.ReadLine(), out Side);

                if (Flag == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value. Only enter numeric values.... Enter the value of a side of the cube:");
                }

            }

            Console.WriteLine("Creating object of Cube Class and initializing with value obtained from user");

            Cube cube = new Cube(Side);

            cube.Volume();

            Console.WriteLine();

            Console.WriteLine("Enter the value of the radius of the Sphere:");

            while (true)
            {
                bool Flag = double.TryParse(Console.ReadLine(), out Radius);

                if (Flag == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value. Only enter numeric values.... Enter the value of the radius of the Sphere:");
                }

            }


            Console.WriteLine("Creating object of Sphere Class and initializing with value obtained from user");

            Sphere sphere = new Sphere(Radius);

            sphere.Volume();
        }
    }
}
        
