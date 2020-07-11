using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_5_2
{
    public class MiniZoo
    {
        private Animal[] animals;

        public MiniZoo(Animal[] animals)
        {
            this.animals = animals;
        }

        public void printDietsOfAllAnimal()
        {
            foreach (var item in animals)
            {
                string diets = item.getDiets();
                string name = item.GetType().Name;
                Console.WriteLine($"{name} eats {diets}.");
            }
        }
    }
}
