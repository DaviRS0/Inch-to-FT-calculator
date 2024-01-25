using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Davi Sobral and Connor Donaghey - Assignment 1 Part 2\n");
            
            Console.WriteLine("Davi Sobral programming experience: Moderate\n");

            Console.WriteLine("Connor Donaghey programming experience: Placeholder\n");

            Console.Write("Enteder a value in inches:");
            double inches = Convert.ToDouble(Console.ReadLine());
            double feet = inches / 12;

            feet = Math.Floor(feet);

            double decimals = inches - feet;
            double Multiply = decimals * 12;

            double total = (feet + Multiply) / 100;



            Console.WriteLine($"{inches} in inches is {feet} feet {total = Math.Floor(total)} inches");


        }
    }
}