using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildCircleTimeLab
{
    class Circle //This class will store data about the circle
    {

      

        //Properties
        public double radius { get; set; }


        public Circle(double radius)//Constructor
        {
            this.radius = radius;

        }

        public double CalculateCircuference(double radius)
        {
            double circum = 2 * Math.PI * radius;
            
            Console.WriteLine($"Cirumference: {circum}");
           // this.circum = circum;
            return circum;
        }

        public double CalculateArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"Area: {area}");
           // this.area = area;
            return area;
        }
        public override string ToString()
        {
            
            string output = $"Radius: {radius} \n";
            output += $"Circumference: {CalculateCircuference(radius)} \n";
            output += $"Area: {CalculateArea(radius)} \n";

            return output;
        }

    }
}
