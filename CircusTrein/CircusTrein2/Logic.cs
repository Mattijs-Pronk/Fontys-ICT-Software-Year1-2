using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Logic
    {
        public List<Animal> animals = new List<Animal>();
        public List<Wagon> train = new List<Wagon>();

        public List<Animal> carnivores = new List<Animal>();
        public List<Animal> herbivores = new List<Animal>();

        Animal animal = new Animal();

        public Logic()
        {

        }

        /// <summary>
        /// alle animals in list animals verdelen over list carnivores en list herbivores
        /// </summary>
        public void DevideAnimals()
        {
            foreach(Animal ani in animals)
            {
                if(animal.IsAnimalCarnivore(ani) == true)
                {
                    carnivores.Add(ani);
                }
                else
                {
                    herbivores.Add(ani);
                }
            }
        }

        /// <summary>
        /// alle dieren in list carnivores verdelen over wagons
        /// </summary>
        public void CarnivoresToWagon()
        {
            foreach (Animal animal in carnivores.ToList())
            {
                NewWagon(animal);
                carnivores.Remove(animal);
            }
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
                if (wagon.PutAnimalInWagon(animal) == true)
                {
                    herbivores.Remove(animal);
                    return true;
                }
            }
            if (animal.Size >= 0)
            {
                NewWagon(animal);
                herbivores.Remove(animal);
                return false;
            }
            return false;
        }

        /// <summary>
        /// nieuwe wagon aanmaken
        /// </summary>
        /// <param name="animal">nieuwe wagon aanmaken</param>
        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.PutAnimalInWagon(animal);
            train.Add(wagon);
        }








        //Wagon wagon = new Wagon();
        //List<Animal> animalCart = new List<Animal>();
        //List<Animal> Notsorted = new List<Animal>();

        //public void AddAnimalInWagon(Animal animal)
        //{
        //    if(wagons.Count == 0)
        //    {
        //        Wagon wagon = new Wagon();
        //        wagons.Add(wagon);
        //        animalCart.Add(animal);
        //    }
        //    if(wagon.WagonSizeCheck(animal) == true)
        //    {
        //        if(wagon.CarnivoreCheck(animal) == true)
        //        {
        //            foreach (Animal ani in animals)
        //            {
        //                if (wagon.CarnivoreCheck(ani) == true)
        //                {
        //                    Notsorted.Add(animal);
        //                }
        //                else
        //                {
        //                    foreach (Animal ani1 in animals)
        //                    {
        //                        if(ani1.Size >= animal.Size)
        //                        {
        //                            Notsorted.Add(animal);
        //                        }
        //                        else
        //                        {
        //                            animalCart.Add(animal);
        //                        }
        //                    }
                                
        //                }
        //            }
        //        }
        //        else
        //        {
        //            foreach (Animal ani in animals)
        //            {
        //                if (wagon.CarnivoreCheck(ani) == true)
        //                {
        //                    foreach (Animal ani1 in animals)
        //                    {
        //                        if (ani1.Size <= animal.Size)
        //                        {
        //                            Notsorted.Add(animal);
        //                        }
        //                        else
        //                        {
        //                            animalCart.Add(animal);
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    animalCart.Add(animal);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Notsorted.Add(animal);
        //    }
        //}
    }
}
