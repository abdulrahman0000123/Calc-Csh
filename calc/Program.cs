using System;
using System.Security.Cryptography;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y,r;
            string answer;
            
            Console.WriteLine("Welcome to My Frist App (Calulator)!");
            Console.WriteLine("Enter first number:");
                x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
                y = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Which Opration You want To Do ?");
                Console.WriteLine("Enter a To Sum , b To subtraction m To multiplation");
                answer = Console.ReadLine();

                if (answer == "a")
                {
                    r = x + y;
                    break;
                }
                else if (answer == "b")
                {
                    r = x - y;
                    break;
                }
                else if (answer == "m")
                {
                    r = x * y;
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid choice !");
                }
            } while (true);

            Console.WriteLine("The result is " + r);
            Console.WriteLine("Thank You For Using Calc !");

        }

    }
}