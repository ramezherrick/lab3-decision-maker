using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab3_DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string status = "";
            Console.Write("what is your name?");
            string name = Console.ReadLine();
            
            while (true)
            {
                Console.Write("Enter a number between 1 and 100:");
                int num;

                while(!int.TryParse(Console.ReadLine(), out num))
                    {
                    Console.Write("invalid number Try again");
                    }
                
                while (num < 0 || num > 100)
                {
                    Console.Write("please enter a number between 0 and 100");
                    num = int.Parse(Console.ReadLine());

                    if (num >= 0 && num <= 100) break;
                }



                int remainder = num % 2;

                if (remainder == 0 && num >= 2 && num <= 25)
                {
                    status = "even";
                    Console.WriteLine($"Output: {name} your answer is {status} and less than 25.”");
                }
                else if (remainder == 0 && num >= 26 && num <= 60)
                {
                    status = "even";
                    Console.WriteLine($"Output:{name} your answer is {status}");
                }
                else if (remainder == 0 && num >= 60)
                {
                    status = "even";
                    Console.WriteLine($"Output:{name} your answer is {num} and {status}");
                }
                else if (remainder != 0)
                {
                    status = "odd";
                    Console.WriteLine($"Output:{name} your answer is {num} and {status}");
                }
                Console.Write("Continue? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "y")
                {
                    continue;
                }
                else if (cont == "n")
                {
                    Console.WriteLine("bye");
                    break;
                }
                else
                {
                    Console.Write("invalid entry, please enter (y/n)");
                    cont = Console.ReadLine();
                }

            }
            
        }
    }
}
