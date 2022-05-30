using CircusTrein2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest3
{
    [TestClass]
    public class UTWagon
    {
        [TestMethod]
        public void Test_PutInWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            Wagon wagon = new Wagon();
            wagon.CanFitInWagon(animal);
            wagon.EnoughWagonCapacity(animal);

            bool expected = true;
            int expectedCapacity = 9;

            //Act
            bool actual = wagon.PutInWagon(animal);
            int actualCapacity = wagon.Capacity;

            //Assert
            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualCapacity, expectedCapacity);
        }

        [TestMethod]
        public void Test_CanFitInWagon()
        {
            //Arrange
            Wagon wagon = new Wagon();
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            animal1.Size = 1;
            animal1.Consumption = Animal.AnimalDiet.Herbivore.ToString();
            animal2.Size = 3;
            animal2.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            bool expected = true;


            //Act
            bool actual = wagon.CanFitInWagon(animal1);


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_EnoughWagonCapacity()
        {
            //Arrange
            Animal animal = new Animal();
            Wagon wagon = new Wagon();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            bool expected = true;


            //Act
            bool actual = wagon.EnoughWagonCapacity(animal);


            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
