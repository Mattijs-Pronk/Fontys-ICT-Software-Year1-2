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

        //check of dier voldoet aan de eisen
        public bool PutAnimalInWagon(Animal animal)
        {
            //als dier erbij kan && er is genoeg ruimte in de wagon
            if(AnimalFitCheck(animal) == true && WagonSizeCheck(animal) == true)
            {
                animals.Add(animal);
                Capacity -= animal.Size;
                return true;
            }
            else { return false; }
        }

        //check of dier in list animals kan
        public bool AnimalFitCheck(Animal animal)
        {
            foreach (Animal ani in animals)
            {
                if(CarnivoreCheck(ani) == true)
                {
                    if(ani.Size <= animal.Size)
                    {
                        animal.CannotBeAdded = true;
                        return false;
                    }
                }
                else { return true; }
            }
            return true;
        }

        //past dier nog in wagon kwa size
        public bool WagonSizeCheck(Animal animal)
        {
            if (Capacity - animal.Size >= 0) { return true; }
            else { return false; }
        }

        //is dier groter dan het grootste dier in list animals
        //public bool AnimalSizeCheck(Animal animal)
        //{
        //    var highest = animals.Max(animal => animal.Size);
        //    if (animal.Size > highest) 
        //    { 
        //        return true; 
        //    }
        //    else 
        //    { 
        //        return false; 
        //    }
        //}

        //is dier een carnivore
        public bool CarnivoreCheck(Animal animal)
        {
            if(animal.Consumption == Animal.AnimalDiet.Carnivore.ToString()) { return true; }
            return false;
        }
    }
}
