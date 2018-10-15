using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    class OrderDetail
    {
        public OrderDetail(uint id, Goods goods, uint quantity)
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }
        
        public uint Id { get; set; }

        public Goods Goods { get; set; }

        public uint Quantity { get; set; }
    }
}
