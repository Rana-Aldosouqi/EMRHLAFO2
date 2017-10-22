using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, d, t, u, n;


            while (true)
            {
                Console.WriteLine("enter the number to convert");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("zero");

                }

                h = n / 100;
                t = ((n / 10) % 10);
                d = n % 100;
                u = n % 10;
                if (t == 1)
                {
                    u = 0;
                }

                if (h > 0 && h <= 9)
                {
                    switch (h)
                    {
                        case (1):
                            Console.Write("one handred");
                            break;
                        case (2):
                            Console.Write("Two handred ");
                            break;
                        case (3):
                            Console.Write("three handred");
                            break;
                        case (4):
                            Console.Write("four handred");
                            break;
                        case (5):
                            Console.Write("five handred");
                            break;
                        case (6):
                            Console.Write("six handred");
                            break;
                        case (7):
                            Console.Write("seven handred");
                            break;
                        case (8):
                            Console.Write("eight handred ");
                            break;
                        case (9):
                            Console.Write("nine handred ");
                            break;
                    }

                }


                if (d >= 10 && d <= 19)
                {
                    switch (d)
                    {
                        case (10):
                            Console.WriteLine("Ten");
                            break;
                        case (11):
                            Console.WriteLine("eleven");
                            break;
                        case (12):
                            Console.WriteLine("Twelve");
                            break;
                        case (13):
                            Console.WriteLine("Thirteen");
                            break;
                        case (14):
                            Console.WriteLine("Fourteen");
                            break;
                        case (15):
                            Console.WriteLine("fifteen");
                            break;
                        case (16):
                            Console.WriteLine("sixteen");
                            break;
                        case (17):
                            Console.WriteLine("seventeen");
                            break;
                        case (18):
                            Console.WriteLine("eighteen");
                            break;
                        case (19):
                            Console.WriteLine("nineteen");
                            break;
                    }

                }


                if (t > 1 && t <= 9)
                {
                    switch (t)
                    {
                        case (2):
                            Console.Write(" twenty");
                            break;
                        case (3):
                            Console.Write(" Thirty");
                            break;
                        case (4):
                            Console.Write(" Forty ");
                            break;
                        case 5:
                            Console.Write(" Fifty ");
                            break;
                        case 6:
                            Console.Write(" Sixty");
                            break;
                        case 7:
                            Console.Write(" Seventy ");
                            break;
                        case 8:
                            Console.Write(" Eighty ");
                            break;
                        case 9:
                            Console.Write(" Ninety ");
                            break;

                    }
                }

                if (u > 0 && u <= 9)
                {
                    switch (u)
                    {


                        case (1):
                            Console.WriteLine(" one");
                            break;
                        case (2):
                            Console.WriteLine(" Two");
                            break;
                        case (3):
                            Console.WriteLine(" Three");
                            break;
                        case (4):
                            Console.WriteLine(" Four ");
                            break;
                        case 5:
                            Console.WriteLine(" Five ");
                            break;
                        case 6:
                            Console.WriteLine(" Six ");
                            break;
                        case 7:
                            Console.WriteLine(" Seven ");
                            break;
                        case 8:
                            Console.WriteLine(" Eight ");
                            break;
                        case 9:
                            Console.WriteLine(" Nine ");
                            break;
                    }
                }













                Console.ReadKey();
            }

            Console.WriteLine(""); 
        }

    } 
    }



