using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal interface iHardwareRepo
    {
        Hardware[] GetAllByTitle (string titlepart);
    }
}
