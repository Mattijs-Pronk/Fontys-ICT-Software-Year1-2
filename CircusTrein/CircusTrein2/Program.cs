using System;

namespace CircusTrein2
{
    class Program
    {
        Wagon wagon = new Wagon();
        static void Main(string[] args)
        {

            Program program = new Program();
            program.WagonTest();
        }

        public void WagonTest()
        {
            for (int i = 0; i < 15; i++)
            {
                Animal animal = new Animal();
                animal.AddAnimal();
                //logic.CanAnimalFitInWagon(animal);
                wagon.animals.Add(animal);
            }
            //wagon.ReListOnConsumptionType();
            //wagon.FillWagon();

            foreach(Animal animal1 in wagon.wagonsmatch)
            {
                Console.WriteLine(animal1.Size + animal1.Consumption);
            }
        }
    }
}
