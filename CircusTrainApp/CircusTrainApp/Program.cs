using System;

namespace CircusTrainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Random random = new Random();

            int randomAnimalCount = random.Next(5, 10);
            for (int a = 0; a < randomAnimalCount; a++)
            {
                train.AddAnimal(RandomAnimal(random));
            }

            //train.AddAnimal(new Animal(Size.Medium, EatingPreference.Herbivore));
            //train.AddAnimal(new Animal(Size.Small, EatingPreference.Carnivore));
            //train.AddAnimal(new Animal(Size.Large, EatingPreference.Herbivore));
            //train.AddAnimal(new Animal(Size.Medium, EatingPreference.Carnivore));
            //train.AddAnimal(new Animal(Size.Medium, EatingPreference.Herbivore));

            DisplayTrain(train);
        }

        static Animal RandomAnimal(Random random)
        {
            int randomSize = random.Next(0, 3);
            int randomEatingPreference = random.Next(0, 2);

            Animal randomAnimal = (randomSize, randomEatingPreference) switch
            {
                (0, 0) => new Animal(Size.Small, EatingPreference.Carnivore),
                (1, 0) => new Animal(Size.Medium, EatingPreference.Carnivore),
                (2, 0) => new Animal(Size.Large, EatingPreference.Carnivore),
                (0, 1) => new Animal(Size.Small, EatingPreference.Herbivore),
                (1, 1) => new Animal(Size.Medium, EatingPreference.Herbivore),
                (2, 1) => new Animal(Size.Large, EatingPreference.Herbivore),
                _ => throw new NotImplementedException(),
            };
            return randomAnimal;
        }

        static void DisplayTrain(Train train)
        {
            int i = 1;

            foreach (Wagon wagon in train.GetWagons())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wagon: " + i);

                foreach (Animal animal in wagon.GetAnimals())
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(animal);
                }

                i++;
                Console.WriteLine();
            }
        }
    }
}