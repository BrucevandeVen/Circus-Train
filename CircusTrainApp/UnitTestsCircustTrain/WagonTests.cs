using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrainApp;

namespace UnitTestsCircustTrain
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void CheckCapacity_AnimalIsTooBig_ReturnsFalse()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Large, EatingPreference.Herbivore));
            wagon.AddAnimal(new Animal(Size.Medium, EatingPreference.Carnivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Large, EatingPreference.Herbivore));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckCapacity_AnimalIsNotTooBig_ReturnsTrue()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Large, EatingPreference.Herbivore));
            wagon.AddAnimal(new Animal(Size.Medium, EatingPreference.Herbivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Small, EatingPreference.Herbivore));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckWagonForEqualOrBiggerCarnivore_AnimalIsEqualOrBiggerCarnivore_ReturnsFalse()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Large, EatingPreference.Carnivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Medium, EatingPreference.Herbivore));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckWagonForEqualOrBiggerCarnivore_AnimalIsNotEqualOrBiggerCarnivore_ReturnsTrue()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Large, EatingPreference.Herbivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Medium, EatingPreference.Herbivore));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckNewAnimalForEqualOrBiggerCarnivore_NewAnimalIsEqualOrBiggerCarnivore_ReturnsFalse()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Medium, EatingPreference.Herbivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Medium, EatingPreference.Carnivore));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckNewAnimalForEqualOrBiggerCarnivore_NewAnimalIsNotEqualOrBiggerCarnivore_ReturnsTrue()
        {
            var wagon = new Wagon();
            wagon.AddAnimal(new Animal(Size.Large, EatingPreference.Herbivore));

            var result = wagon.CanAnimalBeAdded(new Animal(Size.Medium, EatingPreference.Carnivore));

            Assert.IsTrue(result);
        }
    }
}
