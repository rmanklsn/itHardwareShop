using System;
using System.linq;

namespace Store_memory;

public class Hardware_repo : iHardwareRepo
{
    private readonly Hardware[] IT_Hardware = new[]
    {
        new Hardware(1,"Amd 3000G"),
        new Hardware(2,"RTX 4080"),
        new Hardware(3,"Amd ryzen 7 5700"),
    };
    public Hardware[] GetAllByTitle (string titlepart)
    {
        return IT_Hardware(IT_Hard => IT_Hard.Title.Contains(titlepart)).ToArray();
    }
}
