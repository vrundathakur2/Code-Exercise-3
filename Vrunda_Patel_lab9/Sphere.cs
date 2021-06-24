using System;
using System.Collections.Generic;
using System.Text;

namespace Vrunda_Patel_lab9
{
    class Sphere : IShape
    {
        public string Name { get; set; } = "Sphere";
        public double Radius { get; set; }


        public Sphere(double radius)
        {
            this.Radius = radius;
        }

        public void Volume()
        {
            double Volume = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
            Console.WriteLine("The volume of the {0} is : {1}", this.Name, Volume.ToString());
        }
    }
}
