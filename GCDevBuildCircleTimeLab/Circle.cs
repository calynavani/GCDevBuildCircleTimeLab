using System;

namespace GCDevBuildCircleTimeLab
{
    class Circle //This class will store data about the circle
    {



        //Properties
        public double radius { get; set; }
        public double circumference;
        public double area;


        public Circle(double radius)//Constructor
        {
            this.radius = radius;
        }

        public double CalculateCircuference(double radius)
        {
            circumference = 2 * Math.PI * radius;
            //Console.WriteLine($"Cirumference: {Math.Round(circum,2)}");
            Console.WriteLine($"\nCirumference: {Math.Round(circumference,2)} ");
            // this.circum = circum;
            return circumference;

        }

        public double CalculateArea(double radius)
        {
            area = Math.PI * (radius * radius);
            Console.WriteLine($"\nArea: {Math.Round(area,2)} ");
            // this.area = area;
            return area;

        }
        //public override string ToString()
        //{
        //    foreach (var item in ListOfCircles)
        //    {


        //        string output = $"Radius: {radius} \n";
        //        output += $"Circumference: {circumference} \n";
        //        output += $"Area: {area} \n";
        //        Console.WriteLine(output);
        //    }
        //    return output;
        //}

    }
}
