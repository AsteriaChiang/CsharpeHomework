using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个正整数");
            int num = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            goto outer;
                    }
                    Console.Write(" " + i);
                    n++;
                    if (n < 10)
                        continue;
                    Console.WriteLine();
                    n = 0;
                outer:;
                }
            }
        }
    }
}
