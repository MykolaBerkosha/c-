using System;

namespace Lab_1
{
    public class Program
    {
        static public int Example(int a, int b = 60)
        {
            int c = a / b;
            Console.WriteLine(a.ToString() + " / " + b + " = ~ " + c.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть секунди");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Example(a);
            Console.ReadLine();
        }
    }
}
