using Microsoft.AspNetCore.Mvc;
using Store.Web.Models;

namespace Store.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly iHardwareRepository hardwareRepository;

        public CartController(iHardwareRepository hardwareRepository)
        {
            this.hardwareRepository = hardwareRepository;
        }

        public IActionResult Add(int id)
        {
            var hardware = hardwareRepository.GetById(id);
            if (hardware == null)
            {
                return NotFound();
            }

            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
            {
                cart = new Cart();
            }

            if (cart.Items.ContainsKey(id))
            {
                cart.Items[id]++;
            }
            else
            {
                cart.Items[id] = 1;
            }

            cart.Amount += hardware.Price;

            HttpContext.Session.Set(cart);  

            return RedirectToAction("Index", "Hardware", new { id });
        }
    }
}
