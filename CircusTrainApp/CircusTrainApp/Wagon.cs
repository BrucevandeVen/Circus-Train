using System.Collections.Generic;
using System.Linq;

namespace CircusTrainApp
{
    public class Wagon
    {
        private List<Animal> Animals { get; set; }

        public Wagon()
        {
            this.Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public bool CanAnimalBeAdded(Animal animal)
        {
            return CheckCapacity(animal) && CheckWagonForEqualOrBiggerCarnivore(animal) && CheckNewAnimalForEqualOrBiggerCarnivore(animal);
        }

        private bool CheckCapacity(Animal animal)
        {
            return (Animals.Select(animal => animal.Size).ToList().Sum(size => (int)size) + (int)animal.Size) <= 10;
        }

        private bool CheckWagonForEqualOrBiggerCarnivore(Animal animal)
        {
            return !Animals.Any(wagonAnimal => wagonAnimal.EatingPreference == EatingPreference.Carnivore && wagonAnimal.Size >= animal.Size);
        }

        private bool CheckNewAnimalForEqualOrBiggerCarnivore(Animal animal)
        {
            return !Animals.Any(wagonAnimal => animal.EatingPreference == EatingPreference.Carnivore && animal.Size >= wagonAnimal.Size);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return Animals;
        }
    }
}
