//Create a function that takes a number as an argument, increments the number by +1 and returns the result.
using System;
namespace ReturntheNextNumber
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number : .... ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" number = {addition(num)}");
        }


        static int addition(int num)
        {
            return num + 1;
        }
    }
}
