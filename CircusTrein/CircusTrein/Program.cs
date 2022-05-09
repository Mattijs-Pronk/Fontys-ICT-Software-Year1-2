using System;

namespace CircusTrein
{
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
            //foreach (Animal animal in logic.ListAnimals())
            //{
            //    Console.WriteLine("Animal with: " + animal.AnimalId + " Id " + Convert.ToString(animal.Size) + animal.Consumption);
            //}

            //foreach (Wagon wagon in logic.ListWagons())
            //{
            //    Console.WriteLine("Wagon with: " + wagon.WagonId +" Id "+ Convert.ToString(wagon.Capacity));
            //}

            Animal animal1 = new Animal();
            animal1.AddAnimal();
            logic.filledwagons.Add(animal1);

            for (int i = 0; i < 6; i++)
            {
                Animal animal = new Animal();
                animal.AddAnimal();
                logic.CanAnimalFitInWagon(animal);
            }

            Console.WriteLine(logic.filledwagons.Count);
        }
    }
}
