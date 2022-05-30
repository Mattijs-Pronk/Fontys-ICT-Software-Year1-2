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
    public class UTTrain
    {
        Train train = new Train();

        [TestMethod]
        public void Test_AnimalToWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 1;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            bool expected = false;


            //Act
            bool actual = train.AnimalToWagon(animal);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NewWagon()
        {
            //Arrange
            Animal animal = new Animal();
            animal.Size = 3;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            int expected = 1;

            //Act
            int actual = train.NewWagon(animal);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
