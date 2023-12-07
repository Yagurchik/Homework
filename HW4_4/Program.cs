namespace HW4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите ваш доход:");
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                double tax = result * 0.13;
                Console.WriteLine("Налог для уплаты в конце месяца составит: " + tax);
            }
            else
            {
                Console.WriteLine("неверные данные");
            }
        }
    }
}
