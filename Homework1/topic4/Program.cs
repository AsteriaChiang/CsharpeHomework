using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the first number");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number");
            float b = float.Parse(Console.ReadLine());
            float addNum = a + b;
            Console.WriteLine("两大数相加结果为：{0}", addNum);
        }
    }
}
