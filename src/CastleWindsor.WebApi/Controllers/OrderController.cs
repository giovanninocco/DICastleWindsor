using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.ApplicationServices;

namespace WebApplication1.Controllers
{
    public class OrderController : ApiController, IController
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService, IBookingService bookingService, ICompositeService compositeService)
        {
            _orderService = orderService;
            bookingService.MakeBooking();
            string res = compositeService.GetCompositeData();
        }

        // GET: api/Order
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", _orderService.GetOrderId().ToString() };
        }

        // GET: api/Order/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
