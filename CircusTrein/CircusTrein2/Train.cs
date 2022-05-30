using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Train
    {
        List<Wagon> train = new List<Wagon>();

        public Train()
        {

        }

        /// <summary>
        /// alle wagons checken of dier erbij kan, zoniet maak een nieuw wagon
        /// </summary>
        /// <param name="animal">meegestuurde properties van animal</param>
        /// <returns>true or false</returns>
        public bool AnimalToWagon(Animal animal)
        {
            foreach (Wagon wagon in train)
            {
                if (wagon.PutInWagon(animal) == true)
                {
                    return true;
                }
            }
            if (animal.Size >= 0)
            {
                NewWagon(animal);
                return false;
            }
            return false;
        }

        /// <summary>
        /// nieuwe wagon aanmaken
        /// </summary>
        /// <param name="animal">nieuwe wagon aanmaken</param>
        public int NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.PutInWagon(animal);
            train.Add(wagon);

            return train.Count();
        }

        /// <summary>
        /// alle wagons met dieren printen
        /// </summary>
        public void PrintWagons()
        {
            //wagons met dieren printen
            foreach (Wagon wagon in train)
            {
                Console.WriteLine("----------------------New Wagon----------------------");
                Console.WriteLine("Capacity left in wagon: " + wagon.Capacity);
                for (int i = 0; i < wagon.animalsInWagon.Count; i++)
                {
                    Console.WriteLine("Animal size: " + wagon.animalsInWagon[i].Size + "     " + "Animal consumptiontype: " + wagon.animalsInWagon[i].Consumption);
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");
            }

            Console.WriteLine("Amount of wagons: " + train.Count);
        }
    }
}
