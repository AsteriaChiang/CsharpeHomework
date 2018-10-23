using Microsoft.VisualStudio.TestTools.UnitTesting;
using topic1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();

        Customer customer1 = new Customer(1, "Customer1");
        Customer customer2 = new Customer(2, "Customer2");
        Goods milk = new Goods(1, "Milk", 69);
        Goods eggs = new Goods(2, "eggs", 4);

        [TestMethod()]
        public void AddOrderTestTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);
            
            os.AddOrder(order1);
            Assert.AreEqual(os.orderDict[order1.Id], order1);
        }

        [TestMethod()]
        public void AddOrderTestFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);
           
            OrderDetail orderDetails2 = new OrderDetail(2, milk, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);

            Assert.AreEqual(os.orderDict[order1.Id], order2);
        }

        [TestMethod()]
        public void RemoveOrderTestTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);
           
            os.AddOrder(order1);
            os.RemoveOrder(order1.Id);
            Assert.AreNotEqual(os.orderDict[order1.Id], order1);
        }

        [TestMethod()]
        public void RemoveOrderTestFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderDetail orderDetails2 = new OrderDetail(2, milk, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.RemoveOrder(order1.Id);

            Assert.AreNotEqual(os.orderDict[order2.Id], order2);
        }

        [TestMethod()]
        public void QueryAllOrderTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            os.AddOrder(order1);
            Assert.AreEqual(os.QueryAllOrders(), "System.Collections.Generic.List`1[topic1.Order]");
        }

        [TestMethod()]
        public void QueryAllOrderFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderDetail orderDetails2 = new OrderDetail(2, milk, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);
            Assert.AreNotEqual(os.QueryAllOrders(), "System.Collections.Generic.List`1[topic1.Order]");
        }

        [TestMethod()]
        public void GetByIdTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            os.AddOrder(order1);
            Assert.AreEqual(os.GetById(order1.Id), order1);
        }

        [TestMethod()]
        public void GetByIdFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderDetail orderDetails2 = new OrderDetail(2, milk, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);

            Assert.AreEqual(os.GetById(order1.Id), order2);
        }

        [TestMethod()]
        public void QueryByGoodsNameTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            os.AddOrder(order1);
            foreach (Order order in os.QueryByGoodsName("Milk"))
            {
                Assert.AreEqual(order, order1);
            }

        }

        [TestMethod()]
        public void QueryByGoodsNameFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);

            foreach (Order order in os.QueryByGoodsName("Milk"))
            {
                Assert.AreEqual(order, order2);
            }
        }

        [TestMethod()]
        public void QueryByCustomerNameTrue()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            os.AddOrder(order1);
            foreach (Order order in os.QueryByCustomerName(order1.Customer.Name))
            {
                Assert.AreEqual(order, order1);
            }

        }

        [TestMethod()]
        public void QueryByCustomerNameFalse()
        {
            OrderDetail orderDetails1 = new OrderDetail(3, milk, 1);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(orderDetails1);

            OrderDetail orderDetails2 = new OrderDetail(2, milk, 2);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(orderDetails1);

            os.AddOrder(order1);
            os.AddOrder(order2);

            foreach (Order order in os.QueryByCustomerName(order1.Customer.Name))
            {
                Assert.AreEqual(order, order2);
            }
        }

    }
}