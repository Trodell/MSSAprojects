using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[3];
            Console.WriteLine("Please input three elements into the array");
            //int num =Int32.Parse(Console.ReadLine());
            for (int i = 0; i < num.Length; i++) {
                Console.WriteLine($"Element {i+1}");
                num[i] =Int32.Parse(Console.ReadLine());
            }
            var result = 0;
            for (int i = 0;i < num.Length; i++)
            {
                result = result + num[i];
              
            }
            Console.WriteLine($"The sum of all elements stored in the array is: {result}");
            Console.ReadLine();
        } 
    }
}
