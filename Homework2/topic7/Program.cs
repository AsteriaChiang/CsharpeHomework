using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数组的大小");
            int a = int.Parse(Console.ReadLine());
            int[] numbers = new int[a];
            Console.WriteLine("输入数组成员,为整数");

            for (int i = 0; i < a; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int max = numbers[1];
            int min = numbers[1];
            for (int i = 0; i < a; i++)
            {
                sum += numbers[i];
                if (max < numbers[i])
                    max = numbers[i];
                if (min > numbers[i])
                    min = numbers[i];
            }
            Console.WriteLine("数组成员的和为：" + sum);
            Console.WriteLine("数组成员的平均值为：" + (sum / a));
            Console.WriteLine("数组中的最大值为：" + max);
            Console.WriteLine("数组中的最小值为：" + min);
        }
    }
}
