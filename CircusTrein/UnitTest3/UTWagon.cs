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
        public void Test_PutAnimalInWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            Wagon wagon = new Wagon();
            wagon.CanAnimalFit(animal);
            wagon.WagonSizeCheck(animal);

            bool expected = true;


            //Act
            bool actual = wagon.PutAnimalInWagon(animal);


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_CanAnimalFit()
        {
            //Arrange
            Animal animal = new Animal();
            Wagon wagon = new Wagon();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Herbivore.ToString();


            bool expected = true;


            //Act
            bool actual = wagon.CanAnimalFit(animal);


            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_WagonSizeCheck()
        {
            //Arrange
            Animal animal = new Animal();
            Wagon wagon = new Wagon();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Herbivore.ToString();

            bool expected = true;


            //Act
            bool actual = wagon.WagonSizeCheck(animal);


            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
