using System;
using System.Collections.Generic;
using System.Linq;

namespace CircusTrein2
{
    public class Program
    {
        Train train = new Train();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Startalgoritm();
        }

        public void Startalgoritm()
        {
            for (int i = 0; i < 15; i++)
            {
                Animal animal = new Animal();
                animal.GenerateAnimal();
                train.AnimalToWagon(animal);
            }

            train.PrintWagons();
        }
    }
}
