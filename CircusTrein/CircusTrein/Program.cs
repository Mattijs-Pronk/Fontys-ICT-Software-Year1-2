using System;
using CircusTrein;

    public class Program
    {
        
        Logic logic = new Logic();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowAddedItems();
        }

        public void ShowAddedItems()
        {
            for (int i = 0; i < 15; i++)
            {
                Animal animal = new Animal();
                animal.AddAnimal();
                logic.AddAnimalToWagons(animal);
            }

            foreach(Animal ani in logic.animals)
            {
                Console.WriteLine(ani.AnimalId + ani.Size + ani.Consumption);
            }
        
        }
    }
