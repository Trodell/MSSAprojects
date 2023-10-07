using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "yes";
            while (option == "Yes" || option == "yes" || option =="y")
            {
                Point P1 = new Point();
            Point P2 = new Point();
            Console.WriteLine("Enter X-Axis for Point 1");
            P1.X=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Axis for Point 1");
            P1.Y=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter X-Axis for Point 2");
            P2.X=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y-Axis for Point 2");
            P2.Y=Int32.Parse(Console.ReadLine());

                if (P1.X < P2.X)
                {
                    if (P1.X < P2.X && P1.Y < P2.Y)
                    {
                        Console.WriteLine("Point 1 is below and to the left of Point 2");
                    }
                    else if (P1.X < P2.X && P1.Y > P2.Y)
                    {
                        Console.WriteLine("Point 1 is above and to the left of Point 2 ");
                    }
                }
                if (P1.X == P2.X)
                {
                    if (P1.X == P2.X && P1.Y > P2.Y)
                    {
                        Console.WriteLine("Point 1 is above Point 2 and they share the same X-axis");
                    }
                    else if (P1.X == P2.X && P1.Y < P2.Y)
                    {
                        Console.WriteLine("Point 1 is below Point 2 and they share the same X-axis");
                    }
                }
                if (P1.X > P2.X)
                {
                    if (P1.X > P2.X && P1.Y > P2.Y)
                    {
                        Console.WriteLine("Point 1 is above and to the right of point 2");
                    }
                    else if (P1.X > P2.X && P1.Y < P2.Y)
                    {
                        Console.WriteLine("Point 1 is above and to the left of Point 2");

                    }
                   
                }
                if (P1.Y == P2.Y)
                {
                    if (P1.Y == P2.Y && P1.X > P2.X)
                    {
                        Console.WriteLine("Point 1 is to the right of Point 2 and they share the same Y-axis");
                    }
                    else if (P1.Y == P2.Y && P1.X < P2.X)
                    {
                        Console.WriteLine("Point 1 is to the left of Point 2 and they share the same Y-axis");
                    }
                }
                if (P1.X == P2.X && P1.Y == P2.Y)
                {
                    Console.WriteLine("Point 1 and Point 2 are the same point!");
                }

                Console.WriteLine("Would you like to try again? (Yes or No)");
                option = (Console.ReadLine());
                if (option == "no"  || option =="No") 
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey();
                }
        }
           
        }
        
    }
}
