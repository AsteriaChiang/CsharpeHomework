using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    class OrderService
    {

        private Dictionary<uint, Order> orderDict;
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

        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderDict.Values
                .Where(order => order.Customer.Name == customerName);
            return query.ToList();
        }

    }
}
