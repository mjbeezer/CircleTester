
using System;
using System.Collections.Generic;

namespace Circle_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circles Tester!");
            bool runProgram = true;
            bool keepGoing = true;
            int counter = 0;

            //create list to count circles
            List<Circles> Circles = new List<Circles>();

            while (runProgram)
            {

                //user input and arithmetic
                Console.WriteLine("Please enter a radius");
                
                try
                {
                    double radius = double.Parse(Console.ReadLine());
                    if (radius <= 0)
                    {
                        Console.WriteLine("Please enter a number above 0.");
                        continue;
                    }
                    else
                    {
                        //call methods for calculations
                        Circles circle = new Circles(radius);
                        counter++;
                        //add count to list
                        Circles.Add(circle);

                        //display circunference and area
                        Console.WriteLine($"Area is: {circle.CalculateFormattedArea()}");
                        Console.WriteLine($"Circumference is: {circle.CalculateFormattedCircumference()}");
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                    while (keepGoing)
                    {
                        Console.WriteLine("Would you like to make another circle?");
                        string choice = Console.ReadLine().ToLower();
                        if (choice == "y")
                        {
                            keepGoing = true;
                            break;
                        }
                        else if (choice == "n")
                        {
                            keepGoing = false;
                            runProgram = false;
                            Console.WriteLine($"You have calculated {Circles.Count} circles.");
                            Console.WriteLine("Goodbye");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Thats not an answer!");
                        }
                    }
                
            }
        }
    }
}

