using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Wagon
    {
        public List<Animal> animals = new List<Animal>();
        public List<Animal> wagons = new List<Animal>();

        public int Capacity { get; set; }

        public Wagon()
        {
            this.Capacity = 10;
        }

        public Wagon(int capacity)
        {
            this.Capacity = capacity;
        }

        public void PutAnimalInWagon(Animal animal)
        {
            if(AnimalFitCheck(animal) == true && WagonSizeCheck(animal) == true)
            {
                wagons.Add(animal);
                animals.Remove(animal);
            }
        }

        public bool WagonSizeCheck(Animal animal)
        {
            if (Capacity - animal.Size >= 0)
            {
                Capacity -= animal.Size;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AnimalFitCheck(Animal animal)
        {
            foreach(Animal ani in animals)
            {
                //als dieren in wagon carnivore zijn en dier wat erbij moet herbivore is, dier wat erbij moet groter is.
                if (CarnivoreCheck(ani) == true && CarnivoreCheck(animal) == false && AnimalSizeCheck(animal) == true)
                {
                    return true;
                }
                //als dieren in wagon herbivore zijn en dier wat erbij moet ook herbivore is.
                if (CarnivoreCheck(ani) == false && CarnivoreCheck(animal) == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AnimalSizeCheck(Animal animal)
        {
            var highest = animals.Max(animal => animal.Size);
            if (animal.Size > highest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CarnivoreCheck(Animal animal)
        {
            if(animal.Consumption == Animal.AnimalDiet.Carnivore.ToString())
            {
                return true;
            }
            return false;
        }
    }
}
