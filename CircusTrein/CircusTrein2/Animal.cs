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

        /// <summary>
        /// check of het dier een carnivore is
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsCarnivore()
        {
            if (this.Consumption == AnimalDiet.Carnivore.ToString()) { return true; }
            else { return false; }
        }

        /// <summary>
        /// check of het dier groter is dan meegestuurd dier
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
        public bool IsBigger(Animal animal)
        {
            if (this.Size >= animal.Size)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// dier aanmaken met random size en consumption.
        /// </summary>
        public void GenerateAnimal()
        {
            GetRandomSize();
            GetRandomConsumption();
        }

        /// <summary>
        /// size van dier bepalen aan de hand van randoms
        /// </summary>
        /// <returns>int die tussen de 1 en 5 ligt</returns>
        public int GetRandomSize()
        {
            Random rnd = new Random();
            int animalsize = rnd.Next(1, 4);

            if (animalsize == 1) { this.Size = (int)AnimalSize.Small; }
            else if (animalsize == 2) { this.Size = (int)AnimalSize.Medium; }
            else { this.Size = (int)AnimalSize.Big; }

            return this.Size;
        }

        /// <summary>
        /// consumption van dier bepalen aan de hand van randoms
        /// </summary>
        /// <returns>herbivore of carnivore</returns>
        public string GetRandomConsumption()
        {
            Random rnd = new Random();
            int animalconsumption = rnd.Next(1, 3);

            //carnivore kans verlagen door 2e random toevoegen.
            int consumptionchance = rnd.Next(1, 3);

            if (animalconsumption == 1) { this.Consumption = AnimalDiet.Herbivore.ToString(); }
            else if(consumptionchance == 1) { this.Consumption = AnimalDiet.Herbivore.ToString(); }
            else { this.Consumption = AnimalDiet.Carnivore.ToString(); }

            return this.Consumption;
        }
    }
}
