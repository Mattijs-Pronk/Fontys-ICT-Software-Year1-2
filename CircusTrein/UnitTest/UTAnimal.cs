using CircusTrein2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    class UTAnimal
    {
        [TestMethod]
        public void Test_IsAnimalCarnivore(Animal animal)
        {
            //Arrange
            animal.Size = 3;
            animal.Consumption = Animal.AnimalDiet.Carnivore.ToString();

            bool expected = true;

            //Act
            bool actual = animal.IsAnimalCarnivore(animal);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
