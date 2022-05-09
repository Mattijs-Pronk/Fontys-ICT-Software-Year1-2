using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public static int i { get; set; }
        public int AnimalId { get; set; }
        public int Size { get; set; }
        public string Consumption { get; set; }

        

        

        public Animal()
        {

        }

        public Animal(int animalId, int size, string consumption)
        {
            this.AnimalId = animalId;
            this.Size = size;
            this.Consumption = consumption;
        }

        public int GetSize()
        {
            Random rnd = new Random();
            var animalsize = rnd.Next(1,4);

            if(animalsize == 1) { this.Size = (int)AnimalSize.Small; }
            else if(animalsize == 2) { this.Size = (int)AnimalSize.Medium; }
            else { this.Size = (int)AnimalSize.Big; }

            return this.Size;
        }

        public string GetConsumption()
        {
            Random rnd = new Random();
            var animalconsumption = rnd.Next(1, 3);

            if(animalconsumption == 1) { this.Consumption = AnimalDiet.Herbivore.ToString(); }
            else { this.Consumption = AnimalDiet.Carnivore.ToString(); }

            return this.Consumption;
        }

        public void AddAnimal()
        {
            StaticId.AnimalI += 1;
            this.AnimalId = StaticId.AnimalI;
            GetSize();
            GetConsumption();
            Animal animal = new Animal(AnimalId, Size, Consumption);
        }
    }
}
