using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic2
{
    class Program
    {
        //订单：订单号，客户名称
        public class Order
        {
            string orderNumber;
            string clientName;
            public void completeOrder()
            {
                Console.WriteLine("Please input the number of order");
                orderNumber = Console.ReadLine();
                Console.WriteLine("Please input the name of client");
                clientName = Console.ReadLine();
            }
    }
        //订单明细：商品、价格等细节
        public class OrderDetails
        {
            string goodName;
            float goodPrice;
            int goodNumber;
            float orderPrice;
            public void completeOrder()
            {
                Console.WriteLine("Please input the name of good");
                goodName = Console.ReadLine();
                Console.WriteLine("Please input the price of good");
                goodPrice = float.Parse(Console.ReadLine());
                Console.WriteLine("Please input the number of good");
                goodNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input the price of order");
                orderPrice = float.Parse(Console.ReadLine());
            }
        }
        //订单服务：添加、删除、修改、查询订单
        public class OrderService
        {
            List<object> orderList = new List<object>();
            public void addOrder()
            {
                
            }
            public void deleteOrder()
            {

            }
            public void changeOrder()
            {

            }
            public void searchOrder()
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
