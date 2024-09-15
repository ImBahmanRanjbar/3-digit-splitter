using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_digit_splitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "3-digit-splitter";
            while (2 != 3)
            {
                Console.WriteLine("Please enter your digits : ");
                string x = Console.ReadLine();
                string b = null;
                string c = "";
                for (int i = x.Length - 1; i >= 0; i--)
                {
                    b += x[i];
                }
                int count = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    count++;
                    c += b[i];
                    if (count % 3 == 0 && i != b.Length - 1)
                    {
                        c = c + ",";


                    }
                }
                string finaly = "";
                for (int i = c.Length - 1; i >= 0; i--)
                {
                    finaly += c[i];
                }
                Console.WriteLine(finaly);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
