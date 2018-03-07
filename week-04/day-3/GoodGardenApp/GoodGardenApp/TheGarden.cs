using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class TheGarden
    {
        static List<Plant> plants = new List<Plant>();

        public void AddPlant(Flower flower)
        {
            plants.Add(flower);
        }

        public void AddPlant(Tree tree)
        {
            plants.Add(tree);
        }
        public void StateOfGarden()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].WhatsUp();
            }
            
        }
        public void PlantWaterer(double wateringAmount)
        {
           
            
            double portion = wateringAmount / plants.Count;
            for (int i = 0; i < plants.Count; i++)
            {

                    plants[i].WaterPlants(portion);

            }
            Console.WriteLine();
        }
    }
}
