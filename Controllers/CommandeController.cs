using Microsoft.AspNetCore.Mvc;
namespace webService.Controllers;
using System.Collections.Generic;


[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private static List<Order> Orders = new List<Order>();
    
    // GET api/orders/5
    [HttpGet("{id}")]
    public ActionResult<Order> GetOrderById(int id)
    {
        var order = Orders.FirstOrDefault(o => o.Id == id);
        if (order != null)
        {
            return Ok(order);
        }
        else
        {
            return NotFound();
        }
    }

    // POST api/orders
    [HttpPost]
    public ActionResult<Order> CreateOrder(Order order)
    {
        Orders.Add(order);
        return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
    }

    // PUT api/orders/5
    [HttpPut("{id}")]
    public ActionResult UpdateOrderStatus(int id, string status)
    {
        var order = Orders.FirstOrDefault(o => o.Id == id);
        if (order == null)
        {
            return NotFound();
        }

        order.Status = status;
        return NoContent();
    }
}
