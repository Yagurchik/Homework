using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 200;
            while (number<=500) 
            { 
                number++;
                if (number % 17 == 0 && number < (500-17))
                {
                    Console.Write(number + ", ");
                }
                else if (number % 17 == 0)
                {
                        Console.Write(number + ".");
                    }
                else
                {
                    continue;
                }
                    
            }
            
        }
    }
}
