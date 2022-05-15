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

        public List<Animal> animals2 = new List<Animal>();
        public List<Animal> carnivores = new List<Animal>();
        public List<Animal> herbivores = new List<Animal>();

        public Logic()
        {

        }

        Wagon wagon = new Wagon();
        //alle dieren in list animals verdelen over list carnivores en list herbivores
        public void DevideAnimals()
        {
            foreach(Animal ani in animals2)
            {
                if(wagon.CarnivoreCheck(ani) == true)
                {
                    carnivores.Add(ani);
                }
                else
                {
                    herbivores.Add(ani);
                }
            }
        }

        //alle dieren in list carnivores verdelen over wagons
        public void CarnivoresToWagon()
        {
            foreach (Animal animal in carnivores.ToList())
            {
                NewWagon(animal);
                carnivores.Remove(animal);
            }
        }

        //alle wagons checken of dier erbij kan, zoniet maak een nieuw wagon
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
            if (animal.CannotBeAdded == true)
            {
                NewWagon(animal);
                herbivores.Remove(animal);
                return false;
            }
            return false;
        }

        //nieuwe wagon aanmaken
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
