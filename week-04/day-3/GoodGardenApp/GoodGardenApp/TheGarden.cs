using System;
using System.Collections.Generic;
using System.Text;

namespace GoodGardenApp
{
    class TheGarden
    {
        static List<Plant> plants = new List<Plant>();
        public List<Plant> wateringList = new List<Plant>();
        public void AddPlant(Plant plant)
        {
            plants.Add(plant);
            wateringList.Add(plant);
        }

        public void StateOfGarden()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].WhatsUp();

            }

            Console.WriteLine();
        }
        public void PlantWaterer(double wateringAmount)
        {
            double portion = wateringAmount / wateringList.Count;

            for (int i = 0; i < wateringList.Count; i++)
            {
                wateringList[i].waterAmount = wateringList[i].waterAmount + portion * wateringList[i].waterIntake;
                if (wateringList[i].waterAmount > wateringList[i].waterMax)
                {
                    wateringList.Remove(wateringList[i]);
                    i = i - 1;
                }
            }
        }
    }
}
