using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface iHardwareRepository
    {
        Hardware[] GetAllByTitle(string titlePart);

        Hardware[] GetAllByDescription(string descriptionPart);

        Hardware GetById(int id);
    }
      
}
