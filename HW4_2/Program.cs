using System.ComponentModel.Design;

namespace HW4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // поле координат от -2 до 2 по X и Y
            int x = 0;// ось Х
            int y = 0;// ось Y
            while (true) 
            {
                String Key = Console.ReadLine();

                if (Key == "w" || Key == "W")
                {
                    Console.WriteLine("up");
                    if (x < 2)
                    {
                        Console.WriteLine((++x, y));
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine(("no way"));
                    }

                }
                else if (Key == "s" || Key == "S")
                {
                    Console.WriteLine("down");
                    if (x > -2)
                    {
                        Console.WriteLine((--x, y));
                    }
                    else if (x == -2)
                    {
                        Console.WriteLine(("no way"));
                    }
                }
                else if (Key == "a" || Key == "A")
                {
                    Console.WriteLine("left");
                    if (y > -2)
                    {
                        Console.WriteLine((x, --y));
                    }
                    else if (y == -2)
                    {
                        Console.WriteLine(("no way"));
                    }
                }
                else if (Key == "d" || Key == "D")
                {
                    Console.WriteLine("right");
                    if (y < 2)
                    {
                        Console.WriteLine((x, ++y));
                    }
                    else if (y == 2)
                    {
                        Console.WriteLine(("no way"));
                    }
                }
                else if (Key == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("FALSE");
                } 
            }
        }
    }
}
