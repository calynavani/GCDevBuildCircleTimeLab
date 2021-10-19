using System;
using System.Collections.Generic;

namespace GCDevBuildCircleTimeLab
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            bool goOn = true;
            
            while (goOn == true)
            {


                Console.WriteLine();
                double userRadius = GetRadius();

                //make a list for the circles to go into
                List<Circle> ListOfCircles = new List<Circle>();

                //adds a new circle to the list each radius thats entered
                ListOfCircles.Add(new Circle(userRadius));

                //create a circle object
                Circle c = new Circle(userRadius);

                //Display circumerence
                c.CalculateCircuference(userRadius);

                //Display area
                c.CalculateArea(userRadius);

                Console.WriteLine(ListOfCircles.Count);

                //call the continue method
                if (Continue() == false)
                {
                    foreach (var circle in ListOfCircles)//print the list of circles
                    {
                        Console.WriteLine(circle);
                  
                        break;
                    }

                }


            }
        }
            public static double GetRadius()
            {
                Console.WriteLine();
                Console.Write("Enter Radius: ");
                double radius = double.Parse(Console.ReadLine());


               

                return radius;
            }
            public static bool Continue()
            {
                Console.Write("Would you like to continue? y/n: ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    return true;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    return false;



                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand");
                    Console.WriteLine("Let's try again.");


                    return Continue();

                }
            }

        }
    }

