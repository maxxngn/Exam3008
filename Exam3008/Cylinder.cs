using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3008
{
    class Cylinder
    {
        double Radius, Height, BaseArea, LateralArea, TotalArea, Volume;

        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("");
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ", " + "Height: " + Height);
            Console.WriteLine("Base: " + BaseArea + " : " + "Lateral: " + LateralArea + " : " + "ToTal: " + TotalArea + " : " + "Volume: " + Volume);
        }
    }
}
