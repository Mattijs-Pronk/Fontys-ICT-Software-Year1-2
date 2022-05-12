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
                logic.CanAnimalFitInWagon(animal);
            }

            Console.WriteLine(logic.filledwagons.Count);
        }
    }
