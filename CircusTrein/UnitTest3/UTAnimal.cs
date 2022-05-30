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
            bool actual = animal.IsCarnivore();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsBigger()
        {
            //Arrange
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            animal1.Size = 5;
            animal2.Size = 3;

            bool expected = true;

            //Act
            bool actual = animal1.IsBigger(animal2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
