using System;
using System.Collections.Generic;
using System.Linq;

namespace Win95KeygenC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Enter the amount of keys you want: ");
                Generation.GenerateKeys(int.Parse(Console.ReadLine()));

                Generation.PrintToConsole();

                Console.Write("Would you like to write the keys to a file? (Y / N): ");
                string answer = Console.ReadLine().ToUpper();
                if (answer.Equals("Y"))
                {
                    Console.Write("File name: ");
                    Generation.WriteToFile(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }



            Console.ReadKey();
        }
    }
}
