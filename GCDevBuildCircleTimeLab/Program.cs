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
            //make a list for the circles to go into
            List<Circle> ListOfCircles = new List<Circle>();
            
            while (goOn == true)
            {


                Console.WriteLine();
                double userRadius = GetRadius();
                

               
               

                //adds a new circle to the list each radius thats entered
                ListOfCircles.Add(new Circle(userRadius));

                //create a circle object
                Circle c = new Circle(userRadius);

                //Display circumerence
                c.CalculateCircuference(userRadius);

                //Display area
                c.CalculateArea(userRadius);

               

                //call the continue method
                if (Continue() == false)
                {
                    Console.WriteLine($"You've created {ListOfCircles.Count} circles ");//prints the count total
                    //foreach (var circle in ListOfCircles)//print the list of circles
                      //{
                   //    Console.WriteLine(circle);



                    //}

                    //break;
                    for (int i = 0; i < ListOfCircles.Count; i++)
                    {
                       

                    
                    
                       

                        string output = $"Radius: {Math.Round(c.radius,2)} \n";
                        output += $"Circumference: {Math.Round(c.circumference,2)} \n";
                        output += $"Area: {Math.Round(c.area,2)} \n";
                      
                        
                    }
                    goOn = false;

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

