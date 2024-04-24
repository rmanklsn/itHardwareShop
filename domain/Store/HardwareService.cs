using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class HardwareService
    {
        public readonly iHardwareRepository hardwareRepository;

        public HardwareService(iHardwareRepository hardwareRepository)
        {
            this.hardwareRepository = hardwareRepository;
        }

        public Hardware[] GetAllByQuery(string query)
        {
            if (Hardware.isID_N(query))
            {
                return hardwareRepository.GetAllByID_N(query);
            }
            else
            {
                return hardwareRepository.GetAllByTitle(query);
            }
        }
    }
}
