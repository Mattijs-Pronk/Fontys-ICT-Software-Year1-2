using CircusTrein2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using Microsoft.VisualStudio.QualityTools.UnitTestFramework;

namespace UnitTest3
{
    [TestClass]
    public class UTAnimal
    {
        [TestMethod]
        public void Test_IsAnimalCarnivore()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 3;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            bool expected = true;

            //Act
            bool actual = animal.IsAnimalCarnivore(animal);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddAnimal()
        {
            //Arrange 
            Animal expected = new Animal();
            

            //Act
            Animal actual = new Animal();
            actual.AddAnimal();
            expected = actual;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetSize()
        {
            //Arrange
            Animal animal = new Animal();

            int expected;
            int expected1 = 1;
            int expected3 = 3;
            int expected5 = 5;


            //Act
            int actual = animal.GetSize();

            if (actual == 1) { expected = expected1; }
            else if (actual == 3) { expected = expected3; }
            else { expected = expected5; }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetConsumption()
        {
            //Arrange
            Animal animal = new Animal();

            string expected;
            string expected1 = "Carnivore";
            string expected2 = "Herbivore";

            //Act
            string actual = animal.GetConsumption();
            if (actual == "Carnivore") { expected = expected1; }
            else { expected = expected2; }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
