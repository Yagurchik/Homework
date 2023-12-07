namespace HW5_4
{
    internal class Fibachi
    {
        static void Main(string[] args)
        {
            int fib = 1;
            int a = 0;
            bool flag = Int32.TryParse(Console.ReadLine(), out int n);
            if (flag)
            {
                for (int i = 3; i <= n; i++)
                {
                    int c = fib + a;
                    a = fib;
                    fib = c;
                }
                Console.WriteLine(fib);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
