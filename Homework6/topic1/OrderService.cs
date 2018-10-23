using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace topic1
{
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    public  class OrderService
    {

        public Dictionary<uint, Order> orderDict;
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }

        //添加订单
        public void AddOrder(Order order)
        {
            if (orderDict.ContainsKey(order.Id))
                throw new Exception($"order-{order.Id} is already existed!");
            orderDict[order.Id] = order;
        }

        //删除订单
        public void RemoveOrder(uint orderId)
        {
            orderDict.Remove(orderId);
        }

        //修改订单
        public List<Order> QueryAllOrders()
        {
            return orderDict.Values.ToList();
        }

        //查询订单
        public Order GetById(uint orderId)
        {
            return orderDict[orderId];
        }

        //由商品名查询
        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
                var goods = from OrderDetail in order.Details where OrderDetail.Goods.Name == goodsName select order;
                foreach (var n in goods)
                {
                    result.Add(n);
                }
            }
            return result;
        }

        //由客户名查询
        public List<Order> QueryByCustomerName(string customerName)
        {
            var goods = orderDict.Values.Where(order => order.Customer.Name == customerName);
            return goods.ToList();
        }

        //序列化为XML
        public void Export()
        {

            XmlSerializer xmlser = new XmlSerializer(typeof(Order));
            String xmlFileName = "C://Users//Astoria//Desktop//order.xml";
            FileStream fs = new FileStream(xmlFileName, FileMode.Create, FileAccess.ReadWrite);
            foreach (Order order in orderDict.Values.ToList())
            {
                xmlser.Serialize(fs, order);
            }
            fs.Close();
        }

        //从XML文件中载入订单
        public void Import()
        {
            String xmlFileName = "C://Users//Astoria//Desktop//order.xml";
            FileStream fs = new FileStream(xmlFileName, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            Dictionary<uint, Order> orderDict1 = xmlser.Deserialize(fs) as Dictionary<uint, Order>;
            foreach (Order order in orderDict.Values.ToList())
            {
                AddOrder(order);
            }
        }

    }
}
