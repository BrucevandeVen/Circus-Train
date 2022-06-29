using System.Collections.Generic;

namespace CircusTrainApp
{
    public class Train
    {
        private List<Wagon> Wagons { get; set; }

        public Train()
        {
            this.Wagons = new List<Wagon>();
            Wagons.Add(new Wagon());
        }

        public void AddAnimal(Animal animal)
        {
            bool animalIsAdded = false;

            foreach (Wagon wagon in Wagons)
            {
                if (wagon.CanAnimalBeAdded(animal))
                {
                    wagon.AddAnimal(animal);
                    animalIsAdded = true;
                    break;
                }
            }

            if (!animalIsAdded)
            {
                Wagon newWagon = new Wagon();
                Wagons.Add(newWagon);
                newWagon.AddAnimal(animal);
            }
        }

        public IEnumerable<Wagon> GetWagons()
        {
            return Wagons;
        }
    }
}
