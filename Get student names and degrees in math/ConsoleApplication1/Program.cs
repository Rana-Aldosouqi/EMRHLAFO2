using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of student");
            int x = int.Parse(Console.ReadLine());
            int i;
            string[] name = new string[x];
            int[] degree = new int[x];
            int max = 0;
            for (i = 0; i < x; i++)
            {
                string a;
                Console.WriteLine("enter studet " + (i + 1) + " name");
                a = Console.ReadLine();
                name[i] = a;
                int b;
                Console.WriteLine("enter his/her degree");
                b = int.Parse(Console.ReadLine());
                degree[i] = b;
                if (b>max )
                { 
                    max=b;
                }
               

                
                

            }
            Console.WriteLine("Choose an option from the following menu");
            Console.WriteLine("===========================================");
            Console.WriteLine("[1]-Search for student degree");
            Console.WriteLine("[2]-Get top student name and degree");
            Console.WriteLine("[3]-Change a student name");
            int d = int.Parse(Console.ReadLine());

            if (d == 1)
            {
                Console.WriteLine("Enter the student name");
                string f = Console.ReadLine();
                int r;
                r = Array.IndexOf(name, f);
                Console.WriteLine("student " + f + " score is " + degree[r]);
            }
            if (d==2)
            {
                int g;
                g = Array.IndexOf(degree, max);
                Console.WriteLine("top student name is " + name[g] + " and his/her score is " + max);
            }
            if (d==3)
            {
                Console.WriteLine("type the name of student to be changed (old name)");
                string v;
                v = Console.ReadLine();
                Console .WriteLine ("enter new name ");
                string h;
                h=Console.ReadLine ();

                int z;
                z = Array.IndexOf(name, v);
                name.SetValue(h, z);
                Console.WriteLine("name successfully changed from " + v + " to " + h);
                Console.ReadKey();



                






            }
            Console.ReadKey();

        }

       
    }
}
    



