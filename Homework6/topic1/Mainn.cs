using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace topic1
{
    class Mainn
    {
        public static void Main()
        {
            try
            {

                Customer customer1 = new Customer(1, "Customer1");

                Goods milk = new Goods(1, "Milk", 69);
                Goods eggs = new Goods(2, "eggs", 4);
                Goods apple = new Goods(3, "apple", 5);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);

                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                OrderService os = new OrderService();

                os.AddOrder(order1);
                Console.WriteLine(os.QueryAllOrders());
                

            //    Console.WriteLine("GetAllOrders");
            //    List<Order> orders = os.QueryAllOrders();
            //    foreach (Order od in orders)
            //        Console.WriteLine(od.ToString());

            //    Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
            //    orders = os.QueryByCustomerName("Customer2");
            //    foreach (Order od in orders)
            //        Console.WriteLine(od.ToString());

            //    Console.WriteLine("GetOrdersByGoodsName:'apple'");
            //    orders = os.QueryByGoodsName("apple");
            //    foreach (Order od in orders)
            //        Console.WriteLine(od.ToString());

            //    Console.WriteLine("Remove order(id=2) and qurey all");
            //    os.RemoveOrder(2);
            //    os.QueryAllOrders().ForEach(
            //        od => Console.WriteLine(od));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
