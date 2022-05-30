using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Wagon
    {
        public List<Animal> animalsInWagon = new List<Animal>();

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
        public bool PutInWagon(Animal animal)
        {
            //als dier erbij kan && er is genoeg ruimte in de wagon
            if(CanFitInWagon(animal) == true && EnoughWagonCapacity(animal) == true)
            {
                animalsInWagon.Add(animal);
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
        public bool CanFitInWagon(Animal animal)
        {
            foreach (Animal animaltocheck in animalsInWagon)
            {
                if(animal.IsBigger(animaltocheck) && animal.IsCarnivore()) { return false; }
                if(animaltocheck.IsCarnivore() && animaltocheck.IsBigger(animal)) { return false; }
            }
            return true;
        }

        /// <summary>
        /// check of animal nog in de wagon erbij past
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
        public bool EnoughWagonCapacity(Animal animal)
        {
            if (Capacity - animal.Size >= 0) { return true; }
            else { return false; }
        }
    }
}
