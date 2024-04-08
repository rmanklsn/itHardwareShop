using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class HardwareController : Controller
    {
        private readonly iHardwareRepository hardwareRepository;

        public HardwareController(iHardwareRepository hardwareRepository)
        {
            this.hardwareRepository = hardwareRepository;
        }
        public IActionResult Index(int id)
        {
            Hardware hardware = hardwareRepository.GetById(id);

            return View(hardware);
        }
    }
}
