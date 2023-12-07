using System.Diagnostics;

namespace HomeWork5
{
    internal class Program
    {
        static void Homework5(string[] args)
        {
            if (uint.TryParse(Console.ReadLine(), out uint FNumber) && uint.TryParse(Console.ReadLine(), out uint SNumber))
            {
                for (int mnoj = 1; mnoj <= SNumber; mnoj++)
                {
                    Console.WriteLine(FNumber + " x " + mnoj + " = " + (FNumber * mnoj));
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}