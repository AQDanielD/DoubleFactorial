using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFactorial
{
    internal class Program
    {
        static public void Print(List<int> list, int i)
        {
            if (i < list.Count - 1)
            {
                Console.Write($"{list[i]}*");
            }
            else
            {
                Console.Write($"{list[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input: ");

            int num = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(num);

            int j = num;
            while (j > 1)
            {
                j -= 2;
                if (j > 0)
                {
                    list.Add(j);
                }
            }

            int total = 1; // Initialize total to 1

            Console.Write($"Output: {num}!!   =   ");

            for (int i = 0; i < list.Count; i++)
            {
                total *= list[i];
                Print(list, i);
            }

            Console.Write($"    =   {total}");
            Console.ReadLine();
        }
    }
}

