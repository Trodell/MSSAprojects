using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter if you would like to find the Area for 1. Triangle 2. Square 3. Rectangle");
                string shape = (Console.ReadLine());

            //string shape1 = (Console.ReadLine());
                //int bas=Int32.Parse(Console.ReadLine());
               // int height=Int32.Parse(Console.ReadLine());
                if (shape == "1" || shape =="Triangle" || shape =="triangle")
            {   
                Console.WriteLine("What is the base?");
                int baseLength=Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is the height?");
                int height = Int32.Parse(Console.ReadLine());
                float result = TriangleArea( baseLength, height);
                Console.WriteLine($"The area of the triangle is: {result}");
                
               
            }
                else if (shape=="2" || shape=="Square" || shape == "square")
            {
                Console.WriteLine("What is the length of a side?");
                int side=Int32.Parse(Console.ReadLine());
                float result = SquareArea(side);
                Console.WriteLine($"The area of the square is: {result}");
            }
                else if (shape=="3" || shape=="Rectangle" || shape == "rectangle")
            {
                Console.WriteLine("What is the base?");
                int baseLength=int.Parse(Console.ReadLine());
                Console.WriteLine("What is the height?");
                int height=int.Parse(Console.ReadLine());
                float result=RectangleArea(baseLength, height);
                Console.WriteLine($"The area of the rectangle is: {result}");
            }
                else
            {
                Console.WriteLine("You did not follow direction! Goodbye.");
            }
                Console.ReadKey();
        }
        static float TriangleArea(int baseLength, int height)
        {
            return (baseLength * height) / 2;
        }
        static float SquareArea(int side)
        {
            return (side * side);
        }
        static float RectangleArea(int baseLength, int height)
        {
            return (baseLength * height);
        }
    }
}
