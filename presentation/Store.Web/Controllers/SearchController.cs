using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly iHardwareRepository itHardwareRepository;

        public SearchController(iHardwareRepository itHardwareRepository)
        {
            this.itHardwareRepository = itHardwareRepository;
        }

        public IActionResult Index(string query)
        {
            var itHardWare = itHardwareRepository.GetAllByTitle(query);

            return View("Index", itHardWare);
        }
    }
}
