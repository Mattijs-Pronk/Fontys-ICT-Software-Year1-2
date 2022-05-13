using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein2
{
    public class Logic
    {
        Wagon wagon = new Wagon();

        public List<Animal> animals = new List<Animal>();
        public List<Wagon> train = new List<Wagon>();


        public void ConvertToTrain(Animal animal)
        {
            foreach (Wagon wagon in wagon.wagons)
            {
                foreach (Animal ani in wagon.wagonsmatch)
                {
                    animals.Remove(ani);
                }
                train.Add(wagon);
            }
        }
    }
}
