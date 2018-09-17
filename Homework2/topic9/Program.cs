using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[99];
            for (int i = 0; i < 98; i++)
            {
                numbers[i] = i + 2;
            }
            for (int j = 2; j < 99; j++)
            {
                for (int n = j; n < 99; n = n * 2)
                {
                    for (int i = 0; i < 98; i++)
                    {
                        if (numbers[i] % n == 0 && numbers[i] / n != 1)
                            numbers[i] = 0;
                    }
                }
            }
            for (int i = 0; i < 99; i++)
            {
                if (numbers[i] != 0)
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}
