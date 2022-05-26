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

        /// <summary>
        /// check of animal in wagon past gebasseerd op: heeft de wagon genoeg ruimte en, past animal tussen de andere animals
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
        public bool PutAnimalInWagon(Animal animal)
        {
            //als dier erbij kan && er is genoeg ruimte in de wagon
            if(CanAnimalSizeFitInWagon(animal) == true && WagonSizeCheck(animal) == true)
            {
                animals.Add(animal);
                Capacity -= animal.Size;
                return true;
            }
            else { return false; }
        }

        //check of dier in list animals kan
        /// <summary>
        /// check of animal in list animals past gebasseerd op: is animal een carnivore zo ja, is animal groter dan de carnivore.
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
        public bool CanAnimalSizeFitInWagon(Animal animal)
        {
            foreach (Animal ani in animals)
            {
                if(animal.IsAnimalCarnivore(ani) == true)
                {
                    if(ani.Size >= animal.Size)
                    {
                        return false;
                    }
                }
                else { return true; }
            }
            return true;
        }

        /// <summary>
        /// check of animal nog in de wagon erbij past
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
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
    }
}
