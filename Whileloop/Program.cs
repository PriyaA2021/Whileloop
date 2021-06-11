using System;

namespace Whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, n;
            Console.WriteLine("Enter a number until which you want the numbers to be displayed!");
            n = Convert.ToInt32(Console.ReadLine());
            while(i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
