namespace HW6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число строк:");
            string[] members = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < members.Length; i++)
            {
                members[i] = Console.ReadLine();
            }
            MsvAndStr(members, "word");
            for (int i = 0; i < members.Length; i++)
            {
                Console.Write(members[i] + " ");
            }
        }
        string[] MsvAndStr(string[] members, string value)
        {
            if  (members == null || members.Length == 0 || value == null)
            {
                return members;
            }
            else if ((members.Contains(null)) || (members.Contains(value)))
            {
                for (int i = 0; i < members.Length; i++)
                {
                    if (members[i] == null)
                    {
                        members[i] = value;
                        return members;
                    }
                }
            }
            else
            {
                Array.Resize(ref members, members.Length + 1);
                members[members.Length - 1] = value;
                return members;
            }
        }
    }
}
