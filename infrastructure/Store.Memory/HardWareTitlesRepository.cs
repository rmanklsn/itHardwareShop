using System;
using System.Linq;

namespace Store.Memory
{
    public class HardWareTitlesRepository : iHardwareRepository
    {
        private readonly Hardware[] IT_Hardware = new[]
        {
            new Hardware(1,"Amd 3000G", "processor or cpu", 10.07m),
            new Hardware(2,"RTX 4080", "gaming videocard", 12.00m),
            new Hardware(3,"Amd ryzen 7 5700", "8 cores cpu", 100.1m),
            new Hardware(4,"intel Xeon", "cpu for servers", 1000.00m),
            new Hardware(5, "Sandisk","SSD for desctops and laptops", 50.74m),
        };

        public Hardware[] GetAllByDescription(string descriptionPart)
        {
            throw new NotImplementedException();
        }

        public Hardware GetById(int id)
        {
            return IT_Hardware.Single(hardware => hardware.Id == id);
        }

        public Hardware[] GetAllByTitle(string titlePart)
        {
            return IT_Hardware.Where(Hardware => Hardware.Title.Contains(titlePart)).ToArray();
        }
    }
}
