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

        Hardware[] GetAllByID_N(string id_nPart);

        Hardware[] GetAllByDescription(string descriptionPart);

        Hardware GetById(int id);
    }
      
}
