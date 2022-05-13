﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Logic
    {
        public List<Animal> filledwagons = new List<Animal>();
        public List<Wagon> train = new List<Wagon>();

        public List<Animal> animals = new List<Animal>();
        public List<Wagon> wagons = new List<Wagon>();

        Wagon wagon = new Wagon(1, 10);

        public bool AddAnimalToWagons(Animal animal)
        {
            animals.Add(animal);
            wagons.Add(wagon);
            foreach (Wagon wagon in wagons)
            {
                if (wagon.AddAnimalToWagon(animal))
                {
                    return true;
                }
            }
            if (wagon.maxcapacity == true)
            {
                NewWagon(animal);
                return false;
            }
            return false;
        }

        public void NewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(animal);
            wagons.Add(wagon);
        }

        public List<Animal> ListAnimals()
        {
            List<Animal> listanimals = new List<Animal>();
            //dieren toevoegen.
            for (int i = 0; i < 10; i++)
            {
                Animal animal = new Animal();
                animal.AddAnimal();
                listanimals.Add(animal);
            }

            return listanimals;
        }

        //public void CanAnimalFitInWagon(Animal animal)
        //{
        //    Wagon wagon = new Wagon(1, 10000);
        //    if (filledwagons.Count == 0)
        //    {
        //        filledwagons.Add(animal);
        //        wagon.Capacity -= animal.Size;
        //    }
        //    else
        //    {
        //        //Check of wagon genoeg ruimte heeft
        //        if (animal.Size <= wagon.Capacity)
        //        {
        //            //check of animal geen carnivore is.
        //            if (AnimalCarnivoreCheck(animal) == false)
        //            {
        //                //check voor elk dier in de wagon of het een carnvore is.
        //                foreach (Animal animal1 in filledwagons.ToList())
        //                {
        //                    var anyCarnivores = AnimalCarnivoreCheck(animal1);
        //                    //als er geen carnivoren zijn voeg animal toe.
        //                    if (anyCarnivores == false)
        //                    {
        //                        filledwagons.Add(animal);
        //                        wagon.Capacity -= animal.Size;
        //                        return;
        //                    }
        //                    //als er wel carnivoren zijn.
        //                    else
        //                    {
        //                        if (SizeCheck(animal) == true)
        //                        {
        //                            filledwagons.Add(animal);
        //                            wagon.Capacity -= animal.Size;
        //                            return;
        //                        }
        //                    }

        //                }
        //            }
        //            //als animal wel een carnivore is.
        //            else
        //            {
        //                foreach (Animal animal1 in filledwagons.ToList())
        //                {
        //                    //check voor elk dier in de wagon of het een carnvore is.
        //                    if (AnimalCarnivoreCheck(animal1) == true)
        //                    {
        //                        //AddNewWagon(animal);
        //                        train.Add(new Wagon());
        //                        filledwagons.Add(animal);
        //                        wagon.Capacity -= animal.Size;
        //                        return;

        //                        //NewWagon(animal);
        //                    }
        //                    else if (SizeCheck(animal) == true)
        //                    {
        //                        filledwagons.Add(animal);
        //                        wagon.Capacity -= animal.Size;
        //                        return;
        //                    }
        //                    else
        //                    {
        //                        train.Add(new Wagon());
        //                        filledwagons.Add(animal);
        //                        wagon.Capacity -= animal.Size;
        //                        return;
        //                        //AddNewWagon(animal);
        //                        //NewWagon(animal);
        //                    }
        //                }
        //            }
        //        }
        //        //maak niewe wagon aan.
        //        else
        //        {
        //            train.Add(new Wagon());
        //            filledwagons.Add(animal);
        //            wagon.Capacity -= animal.Size;
        //            return;
        //            //AddNewWagon(animal);
        //            //NewWagon(animal);
        //        }
        //    }
        //}

        public bool SizeCheck(Animal animal)
        {
            var highest = filledwagons.Max(animal => animal.Size);
            if (animal.Size > highest)
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

        public void AddNewWagon(Animal animal)
        {
            filledwagons.Clear();
            filledwagons.Add(animal);
        }
    }
}
