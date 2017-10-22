using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter the number");
                int n = int.Parse(Console.ReadLine());
                string b = Convert.ToString(n, 2);

                int wordCount = b.Length;
                for (int wordIndex = 0; wordIndex < wordCount; wordIndex++)
                {
                    char c = b[wordIndex];

                }

                Console.WriteLine("Enter the position where you want to know its value");
                int p = int.Parse(Console.ReadLine());
                int d = p - 1;
                if (d > wordCount)
                {
                    Console.WriteLine("wrong position");
                }

                Console.WriteLine("the value is " + b[d]);
                Console.ReadKey();
            }
        }
    }
}
