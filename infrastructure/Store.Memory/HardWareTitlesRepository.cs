using System;
using System.Linq;

namespace Store.Memory
{
    public class HardWareTitlesRepository : iHardwareRepository
    {
        private readonly Hardware[] IT_Hardware = new[]
        {
            new Hardware(1,"ID_N12345-60987", "Amd 3000G", "processor or cpu", 10.07m),
            new Hardware(2,"ID_N12345-60986", "RTX 4080", "gaming videocard", 12.00m),
            new Hardware(3,"ID_N12345-60985", "Amd ryzen 7 5700", "8 cores cpu", 100.1m),
            new Hardware(4,"ID_N12345-60984", "intel Xeon", "cpu for servers", 1000.00m), 
            new Hardware(5,"ID_N12345-60983", "Sandisk","SSD for desctops and laptops", 50.74m),
        };

        public Hardware[] GetAllByID_N(string id_nPart)
        {
            return IT_Hardware.Where(hardware => hardware.ID_N == id_nPart).ToArray();
        }

        public Hardware GetById(int id)
        {
            return IT_Hardware.Single(hardware => hardware.Id == id);
        }

        public Hardware[] GetAllByTitle(string titlePart)
        {
            return IT_Hardware.Where(Hardware => Hardware.Title.Contains(titlePart)).ToArray();
        }

        public Hardware[] GetAllByDescription(string descriptionPart)
        {
            throw new NotImplementedException();
        }
    }
}
