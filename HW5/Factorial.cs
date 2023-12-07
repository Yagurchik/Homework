namespace HW5_3
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int fac = 1;
            bool flag = Int32.TryParse(Console.ReadLine(), out int n);
            if (flag)
            {
                for (int i = 1; i <= n; i++) 
                {
                    fac = fac * i;
                }
                Console.WriteLine(fac);
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
