using System;
using System.Linq;

namespace Store.Memory
{
    public class HardWareTitlesRepository : iHardwareRepository
    {
        private readonly Hardware[] IT_Hardware = new[]
        {
            new Hardware(1,"Amd 3000G"),
            new Hardware(2,"RTX 4080"),
            new Hardware(3,"Amd ryzen 7 5700"),
            new Hardware(4,"CPU for servers"),
            new Hardware(5, "SSD for desctops and laptops"),
        };

        public Hardware[] GetAllByTitle(string titlePart)
        {
            return IT_Hardware.Where(Hardware => Hardware.Title.Contains(titlePart)).ToArray();
        }
    }
}
