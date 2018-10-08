using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    class Program
    {
        //声明事件参数
        public class ClockEventArgs : EventArgs
        {
            public bool Clock;
        }
        //声明委托类型
        public delegate void ClockEventHandler(object a, ClockEventArgs e);
        //声明事件源
        public class SetClock
        {
            public event ClockEventHandler Setting;
            static string NowTime = DateTime.Now.ToLongTimeString();
            static string Time;

            public void SetTime()//用户设定时间
            {
                Console.WriteLine(NowTime);
                Console.WriteLine("Please input the hour");
                String hour = Console.ReadLine();
                Console.WriteLine("Please input the minute");
                String minute = Console.ReadLine();
                Console.WriteLine("Please input the second");
                String second = Console.ReadLine();
                Time = hour + ":" + minute + ":" + second;

                if(NowTime == Time)
                {
                    ClockEventArgs args = new ClockEventArgs();
                    args.Clock= String.Equals(Time, NowTime);
                    Setting(this, args);
                }
            }
        }

        static void Main(string[] args)
        {
            SetClock clock = new SetClock();
            //注册事件
            clock.SetTime();
            clock.Setting += ShowProgress;
            //事件处理方法
        }
        static void ShowProgress(object sender, ClockEventArgs e)
        {
            Console.WriteLine("Time is Now!");
        }
    }
}
