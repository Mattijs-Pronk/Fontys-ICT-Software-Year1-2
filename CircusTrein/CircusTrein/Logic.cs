using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Logic
    {
        public List<Animal> filledwagons = new List<Animal>();

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

        public List<Wagon> ListWagons()
        {
            List<Wagon> listwagons = new List<Wagon>();

            for (int i = 0; i < 3; i++)
            {
                Wagon wagon = new Wagon();
                wagon.AddWagon();
                listwagons.Add(wagon);
            }

            return listwagons;
        }

        Wagon wagon = new Wagon(1, 1000);
        public void CanAnimalFitInWagon(Animal animal)
        {
            //if(wagon.Capacity == 10)
            //{
            //    animal.AddAnimal();
            //    wagon.Capacity -= animal.Size;
            //}
            if(filledwagons.Count == 0)
            {
                filledwagons.Add(animal);
                wagon.Capacity -= animal.Size;
            }
            else
            {
                //Check of wagon genoeg ruimte heeft
                if (animal.Size <= wagon.Capacity)
                {
                    //check of animal geen carnivore is.
                    if (AnimalCarnivoreCheck(animal) == false)
                    {
                        //check voor elk dier in de wagon of het een carnvore is.
                        foreach (Animal animal1 in filledwagons.ToList())
                        {
                            var anyCarnivores = AnimalCarnivoreCheck(animal1);
                            //als er geen carnivoren zijn voeg animal toe.
                            if (anyCarnivores == false)
                            {
                                filledwagons.Add(animal);
                                wagon.Capacity -= animal.Size;
                                return;
                            }
                            //als er wel carnivoren zijn.
                            else
                            {
                                if (SizeCheck(animal) == true)
                                {
                                    filledwagons.Add(animal);
                                    wagon.Capacity -= animal.Size;
                                }
                            }

                        }
                    }
                    //als animal wel een carnivore is.
                    else
                    {
                        if (SizeCheck(animal) == true)
                        {
                            filledwagons.Add(animal);
                            wagon.Capacity -= animal.Size;
                        }
                    }

                }
                //maak niewe wagon aan.
                else
                {

                }
            }
            
        }

        public bool AnimalCarnivoreCheck(Animal animal)
        {
            if(animal.Consumption == AnimalDiet.Carnivore.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
    }
}
