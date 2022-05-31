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
            NewWagon(animal);
            return true;
        }

        /// <summary>
        /// nieuwe wagon aanmaken
        /// </summary>
        /// <param name="animal">nieuwe wagon aanmaken</param>
        public int NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            if(wagon.PutInWagon(animal) == false)
            {
                throw new InvalidOperationException("Animal couldn't be added");
            }
            train.Add(wagon);

            return train.Count();
        }

        /// <summary>
        /// alle wagons met inhoud printen
        /// </summary>
        public void PrintWagons()
        {
            //wagons met dieren printen
            foreach (Wagon wagon in train)
            {
                wagon.PrintAnimalsInWagon();
            }

            Console.WriteLine("Amount of wagons: " + train.Count);
        }
    }
}
