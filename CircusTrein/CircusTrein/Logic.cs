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

            //Check of wagon genoeg ruimte heeft
            if (animal.Size <= wagon.Capacity)
            {
                //check of animal een carnivore is.
                if (AnimalCarnivoreCheck(animal) == false)
                {
                    //check voor elk dier in de wagon of het een carnvore is.
                    foreach (Animal animal1 in filledwagons)
                    {
                        //als er geen carnivoren zijn voeg animal toe.
                        if (AnimalCarnivoreCheck(animal1) == false)
                        {
                            filledwagons.Add(animal);
                            wagon.Capacity -= animal.Size;
                        }
                        //als er wel carnivoren zijn.
                        else
                        {
                            //check voor elk dier in de wagon wat de groote is.
                            foreach (Animal animal2 in filledwagons)
                            {
                                //als animal groter is dan elk dier in de wagon voeg animal toe.
                                if (animal.Size > animal2.Size)
                                {
                                    filledwagons.Add(animal);
                                    wagon.Capacity -= animal.Size;
                                }
                            }
                        }

                    }
                }
            }
            //als animal geen carnivore is.
            //else
            //{
            //    //check voor elk dier in de wagon of het een carnvore is.
            //    foreach (Animal animal3 in filledwagons)
            //    {
            //        if (AnimalCarnivoreCheck(animal3) == true)
            //        {
            //            //check voor elk dier in de wagon wat de groote is.
            //            foreach (Animal animal4 in filledwagons)
            //            {
            //                //als animal groter is dan elk dier in de wagon voeg animal toe.
            //                if (animal.Size > animal4.Size)
            //                {
            //                    filledwagons.Add(animal);
            //                }
            //            }
            //        }
            //        else
            //        {
            //            //check voor elk dier in de wagon wat de groote is.
            //            foreach (Animal animal5 in filledwagons)
            //            {
            //                //als animal groter is dan elk dier in de wagon voeg animal toe.
            //                if (animal5.Size > animal.Size)
            //                {
            //                    filledwagons.Add(animal);
            //                }
            //            }
            //        }
            //    }
            //}
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
    }
}
