namespace HW6_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            smith(5, 5);
        }
        static void smith(int x, int y)
        {
            Random next = new Random();
            int[,] neo = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int q = 0; q < y; q++)
                {
                    neo[i, q] = next.Next(100);
                    Console.Write(neo[i, q] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();// для визуального разделения массивов
            int[,] trinity = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int q = 0; q < y; q++)
                {
                    trinity[i, q] = next.Next(100);
                    Console.Write(trinity[i, q] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();// для визуального разделения массивов
            int[,] morbius = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int q = 0; q < y; q++)
                {
                    trinity[i, q] = neo[i, q] + trinity[i, q];
                    Console.Write(trinity[i, q] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


 

