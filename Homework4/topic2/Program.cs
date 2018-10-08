using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic2
{
    class Program
    {
        struct ListObject
        {
            public string number;
            public string name;
            public string goodname;
            public float price;
            public int goodnumber;
            public float total;
            public ListObject(string orderName, string orderNumber, string detailsName, float detailsPrice, int detailsNumber, float detailsTotal)
            {
                number = orderNumber;
                name = orderName;
                goodname = detailsName;
                price = detailsPrice;
                goodnumber = detailsNumber;
                total = detailsTotal;
            }
        }
        //订单：订单号，客户名称
        public class Order
        {
            private string number;
            private string name;
            public Order(string orderNumber, string clientName)
            {
                this.number = orderNumber;
                this.name = clientName ;
            }

            public string Number
            {
                get { return number; }
            }

            public string Name
            {
                get { return name; }
            }
    }
        //订单明细：商品、价格等细节
        public class OrderDetails
        {
            private string name;
            private float price;
            private int number;
            private float total;
            public OrderDetails(string goodName,float goodPrice, int goodNumber,float orderTotal)
            {
                this.name = goodName;
                this.price = goodPrice;
                this.number = goodNumber;;
                this.total = orderTotal;
            }

            public string Name
            {
                get { return name; }
            }

            public float Price
            {
                get { return price; }
            }
           
            public int Number
            {
                get { return number; }
            }

            public float Total
            {
                get { return total; }
            }
        }
        //订单服务：添加、删除、修改、查询订单
        public class OrderService
        {
            List<ListObject> orderList = new List<ListObject>();
            Order order;
            OrderDetails details;
            public OrderService(Order o, OrderDetails d)
            {
                this.order = o;
                this.details = d;
            }
            //添加
            public void addOrder()
            {
                ListObject Listobject= new ListObject( order.Name, order.Number, details.Name, details.Price, details.Number, details.Total );
                orderList.Add(Listobject);
            }
            //删除
            public void deleteOrder(object o)
            {
                for (int i = 0; i < orderList.Count; i++)
                {
                    if ((string)o==orderList[i].Name&& (string)o == orderList[i].Number)
                    {
                        orderList.RemoveAt(i);
                    }
                }
            }
            //修改
            public void changeOrder(object o,Order change)
            {
                for (int i = 0; i < orderList.Count; i++)
                {
                    if ((string)o == orderList[i].Name && (string)o == orderList[i].Number)
                    {
                        orderList[i] = change;
                    }
                }
            }
            //查找
            public Order searchOrder(object o)
            {
                int order=0;
                for (int i = 0; i < orderList.Count; i++)
                {
                    if ((string)o == orderList[i].Name && (string)o == orderList[i].Number)
                    {
                        order = i;
                    }
                }
                return orderList[order];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入订单的订单号");
            string number = Console.ReadLine();
            Console.WriteLine("请输入订单的顾客名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入订单包含的商品");
            string gname = Console.ReadLine();
            Console.WriteLine("请输入商品的价格");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入商品的数量");
            int gnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入订单的总和");
            float total = float.Parse(Console.ReadLine());
            Order order = new Order(number,name);
            OrderDetails details = new OrderDetails(gname, price, gnumber, total);
            OrderService service = new OrderService(order,details);
            service.addOrder();
        }
    }
}
