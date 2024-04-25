using Microsoft.AspNetCore.Mvc;
using Store.Web.Models;

namespace Store.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly iHardwareRepository hardwareRepository;
        private readonly IOrderRepository orderRepository;

        public OrderController(iHardwareRepository hardwareRepository, IOrderRepository orderRepository)
        {
            this.hardwareRepository = hardwareRepository;
            this.orderRepository = orderRepository;
        }

        public IActionResult AddItem(int id)
        {
            
            Order order;
            Cart cart;

            if (HttpContext.Session.TryGetCart(out cart))
            {
                order = orderRepository.GetById(cart.OrderId);
            }
            else
            {
                order = orderRepository.Create();
                cart = new Cart(order.Id);
            }
            var hardware = hardwareRepository.GetById(id);

            order.AddItem(hardware, 1);
            orderRepository.Update(order);

            cart.TotalCount = order.TotalCount;
            cart.TotalPrice = order.TotalPrice;

            HttpContext.Session.Set(cart);  

            return RedirectToAction("Index", "Hardware", new { id });
        }
    }
}
