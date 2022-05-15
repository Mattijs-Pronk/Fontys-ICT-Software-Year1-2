using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Animal
    {
        public int Size { get; set; }
        public string Consumption { get; set; }
        public bool CannotBeAdded { get; set; }

        public enum AnimalSize
        {
            Small = 1,
            Medium = 3,
            Big = 5
        }

        public enum AnimalDiet
        {
            Herbivore,
            Carnivore
        }

        public Animal()
        {

        }

        public Animal(int size, string consumption)
        {
            this.Size = size;
            this.Consumption = consumption;
        }

        //dier aanmaken
        public void AddAnimal()
        {
            GetSize();
            GetConsumption();
            Animal animal = new Animal(Size, Consumption);
        }

        //size van dier bepalen
        public int GetSize()
        {
            Random rnd = new Random();
            var animalsize = rnd.Next(1, 4);

            if (animalsize == 1) { this.Size = (int)AnimalSize.Small; }
            else if (animalsize == 2) { this.Size = (int)AnimalSize.Medium; }
            else { this.Size = (int)AnimalSize.Big; }

            return this.Size;
        }

        //consumption van dier bepalen
        public string GetConsumption()
        {
            Random rnd = new Random();
            var animalconsumption = rnd.Next(1, 3);
            //carnivore kans verlagen door 2e random toevoegen.
            var consumptionchance = rnd.Next(1, 3);

            if (animalconsumption == 1) { this.Consumption = AnimalDiet.Herbivore.ToString(); }
            else if(consumptionchance == 1) { this.Consumption = AnimalDiet.Herbivore.ToString(); }
            else { this.Consumption = AnimalDiet.Carnivore.ToString(); }

            return this.Consumption;
        }
    }
}
