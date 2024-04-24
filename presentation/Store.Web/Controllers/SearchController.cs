using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly HardwareService hardwareService;

        public SearchController(HardwareService hardwareService)
        {
            this.hardwareService = hardwareService;
        }

        public IActionResult Index(string query)
        {
            var itHardWare = hardwareService.GetAllByQuery(query);

            return View(itHardWare);
        }
    }
}
