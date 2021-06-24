using System;
using System.Collections.Generic;
using System.Text;

namespace Vrunda_Patel_lab9
{
    class Cube : IShape
    {
        public string Name { get; set; } = "Cube";
        public double Side { get; set; }

        public Cube(double side)
        {
            this.Side = side;
        }

        public void Volume()
        {
            double Volume = Math.Pow(Side, 3);
            Console.WriteLine("The volume of the {0} is : {1}", this.Name, Volume.ToString());
        }
    }
}
