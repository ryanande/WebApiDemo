using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class OrderModel
    {
        public Guid OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public IEnumerable<OrderItem> Items { get; set; } 
    }

    public class OrderItem
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}