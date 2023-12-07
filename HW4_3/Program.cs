namespace HW4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
                Console.WriteLine(arr[i]);
                if (arr[i] % 17 == 0)
                {
                    goto sort;
                }

            
            }
        sort:
            Console.WriteLine("finish");
        }
    }
}
