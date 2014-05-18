using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class OrderController : ApiController
    {


        [HttpGet]
        [Route("api/Order/{orderId}")]
        public OrderModel Get(Guid orderId)
        {
            return GetOrders().FirstOrDefault(o => o.OrderId == orderId);
        }

        [HttpGet]
        [Route("api/Order")]
        public IEnumerable<OrderModel> List()
        {
            return GetOrders();
        }


        [HttpPost]
        [Route("api/Order")]
        public HttpResponseMessage Post(CreateOrder model)
        {
         
            return  new HttpResponseMessage{ StatusCode = HttpStatusCode.OK };
        }

        public IEnumerable<OrderModel> GetOrders()
        {
            return new List<OrderModel>
            {
                new OrderModel
                {
                    OrderId = new Guid("fbe1462e-0c95-4b7b-95b3-7acecbd1ef0b"),
                    CreateDate = DateTime.Now.AddDays(-3),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ItemId = Guid.NewGuid(), Name = "Jim Dunlop Capo", Quantity = 1},
                        new OrderItem { ItemId = Guid.NewGuid(), Name = "Elixir Nanoweb Guitar Strings", Quantity = 2}
                    }
                },
                new OrderModel
                {
                    OrderId = new Guid("cae1453d-2c82-4d04-9816-ae983defc16f"),
                    CreateDate = DateTime.Now.AddDays(-1),
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ItemId = Guid.NewGuid(), Name = "Jim Dunlop Capo", Quantity = 1},
                        new OrderItem { ItemId = Guid.NewGuid(), Name = "Elixir Nanoweb Guitar Strings", Quantity = 2}
                    }
                }
            };
        }
    
    }


}
