using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public List<Animal> animals = new List<Animal>();
        public int WagonId { get; set; }
        public int Capacity { get; set; }

        public bool maxcapacity = false;

        public Wagon()
        {

        }

        public Wagon(int wagonId, int capacity)
        {
            this.WagonId = wagonId;
            this.Capacity = capacity;
        }

        public bool AddAnimalToWagon(Animal animal)
        {
            if(CanAnimalFit(animal) == true && SizeCheck(animal) == true)
            {
                animals.Add(animal);
                Capacity =- animal.Size;
                maxcapacity = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanAnimalFit(Animal animal)
        {
            foreach(Animal animal1 in animals)
            {
                if(animal1.Size <= animal.Size && AnimalCarnivoreCheck(animal) == true)
                {
                    return true;
                }
                if(animal1.Size >= animal.Size && AnimalCarnivoreCheck(animal1) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool SizeCheck(Animal animal)
        {
            var currentcapacity = Capacity - animal.Size;
            if (currentcapacity >=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AnimalCarnivoreCheck(Animal animal)
        {
            if (animal.Consumption == AnimalDiet.Carnivore.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCapacity()
        {
            StaticId.WagonI += 1;
            this.WagonId = StaticId.WagonI;
            this.Capacity = 10;

            return Capacity;
        }
    }
}
