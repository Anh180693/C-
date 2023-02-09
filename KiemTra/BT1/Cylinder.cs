using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.BT1
{
    internal class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public void Process()
        {
            baseArea = Math.PI * Math.Pow(radius, 2);
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * Math.Pow(radius, 2) * height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + baseArea);
            Console.WriteLine("Lateral Area: " + lateralArea);
            Console.WriteLine("Total Area: " + totalArea);
            Console.WriteLine("Volume: " + volume);
        }
    }
}
