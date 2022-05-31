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
        public void Test_CanBeTogether()
        {
            //Arrange
            Animal animal1 = new Animal();
            animal1.Size = 5;
            animal1.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            Animal animal2 = new Animal();
            animal2.Size = 3;
            animal1.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            Animal animal3 = new Animal();
            animal2.Size = 1;
            animal1.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            Animal animal4 = new Animal();
            animal2.Size = 5;
            animal1.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            bool expectedtrue = true;
            bool expectedfalse = false;

            //Act
            bool actual1 = animal1.CanBeTogether(animal2);
            bool actual2 = animal1.CanBeTogether(animal3);
            bool actual3 = animal1.CanBeTogether(animal4);
            bool actual4 = animal2.CanBeTogether(animal3);
            bool actual5 = animal2.CanBeTogether(animal4);
            bool actual6 = animal3.CanBeTogether(animal4);

            //Assert
            Assert.AreEqual(expectedfalse, actual1);
            Assert.AreEqual(expectedfalse, actual2);
            Assert.AreEqual(expectedfalse, actual3);
            Assert.AreEqual(expectedtrue, actual4);
            Assert.AreEqual(expectedtrue, actual5);
            Assert.AreEqual(expectedtrue, actual6);
        }

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
