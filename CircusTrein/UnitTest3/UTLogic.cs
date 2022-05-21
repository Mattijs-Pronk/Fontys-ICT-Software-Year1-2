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
    public class UTLogic
    {
        Logic logic = new Logic();

        List<Animal> UTanimals = new List<Animal>();

        [TestMethod]
        public void Test_DevideAnimals()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 5;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            logic.animals.Add(animal);
            //UTanimals.Add(animal);

            int expectedCarnivores = 1;
            int expectedHerbivores = 0;


            //Act
            logic.DevideAnimals();
            int actualCarnivores = logic.carnivores.Count();
            int actualHerbivores = logic.herbivores.Count();

            //Assert
            Assert.AreEqual(expectedCarnivores, actualCarnivores);
            Assert.AreEqual(expectedHerbivores, actualHerbivores);
        }

        [TestMethod]
        public void Test_CarnivoresToWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            logic.carnivores.Add(animal);

            int expectedWagons = 1;
            int expectedCarnivores = 0;


            //Act
            logic.CarnivoresToWagon();
            int actualWagons = logic.train.Count();
            int actualCarnivores = logic.carnivores.Count();

            //Assert
            Assert.AreEqual(expectedWagons, actualWagons);
            Assert.AreEqual(expectedCarnivores, actualCarnivores);
        }

        [TestMethod]
        public void Test_AnimalToWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            bool expected = false;


            //Act
            bool actual = logic.AnimalToWagon(animal);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NewWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            int expected = 1;

            //Act
            logic.NewWagon(animal);
            int actual = logic.train.Count();


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
