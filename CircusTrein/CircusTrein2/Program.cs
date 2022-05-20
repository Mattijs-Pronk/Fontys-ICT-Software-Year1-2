using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein2
{
    public class Program
    {
        Logic logic = new Logic();
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Startalgoritm();
            program.DebugChecks();
        }

        public void Startalgoritm()
        {
            for (int i = 0; i < 15; i++)
            {
                Animal animal = new Animal();
                animal.AddAnimal();
                logic.animals.Add(animal);
            }
 
            logic.DevideAnimals();
            logic.CarnivoresToWagon();

            foreach (Animal animal3 in logic.herbivores.ToList())
            {
                logic.AnimalToWagon(animal3);
            }

            //wagons met dieren printen
            foreach(Wagon wagon in logic.train)
            {
                Console.WriteLine("----------------------New Wagon----------------------");
                Console.WriteLine("Capacity left in wagon: " + wagon.Capacity);
                for (int i = 0; i < wagon.animals.Count; i++)
                {
                    Console.WriteLine("Animal size: " + wagon.animals[i].Size + "     " + "Animal consumptiontype: " + wagon.animals[i].Consumption);
                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");
            }

            Console.WriteLine("Amount of wagons: " + logic.train.Count);
            Console.WriteLine("Amount of total animals: " + logic.animals.Count);
        }


        public void DebugChecks()
        {
            //---------------------Debugging checks---------------------
            //als een van onderstaande te zien is zit er een fout in het algoritme

            //zijn er nog carnivores die niet verdeelt zijn, laat aantal zien
            if (logic.carnivores.Count > 0)
            {
                Console.WriteLine("Amount of carnivores not added:" + logic.herbivores.Count);
            }

            //zijn er nog carnivores die niet verdeelt zijn, laat zien welk dier
            foreach (Animal animal2 in logic.carnivores)
            {
                Console.WriteLine(animal2.Size + animal2.Consumption);
            }

            //zijn er nog cherbivores die niet verdeelt zijn, laat aantal zien
            if (logic.herbivores.Count > 0)
            {
                Console.WriteLine("Amount of herbivores not added: " + logic.herbivores.Count);
            }

            //zijn er nog carnivores die niet verdeelt zijn, laat zien welk dier
            foreach (Animal animal1 in logic.herbivores)
            {
                Console.WriteLine(animal1.Size + animal1.Consumption);
            }
        }
    }
}
