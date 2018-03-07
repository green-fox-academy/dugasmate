using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garden
    {
        public List<Garden> flowersAndTrees = new List<Garden>();
        public List<Garden> wateringList = new List<Garden>();
        public string color, type;
        public double waterAmount;
        public Garden(string color = "brown", string type = "plant")
        {
            this.color = color;
            this.type = type;
            waterAmount = 0;
        }
        public void AddPlant(Garden plant)
        {
            flowersAndTrees.Add(plant);
            wateringList.Add(plant);
        }

        public void StateOfGarden()
        {
            for (int i = 0; i < flowersAndTrees.Count; i++)
            {
                if (flowersAndTrees[i].type == "flower" && flowersAndTrees[i].waterAmount < 5)
                {
                    Console.WriteLine("The " + flowersAndTrees[i].color + " " + flowersAndTrees[i].type + " needs water.");
                }
                else if (flowersAndTrees[i].type == "tree" && flowersAndTrees[i].waterAmount < 10)
                {
                    Console.WriteLine("The " + flowersAndTrees[i].color + " " + flowersAndTrees[i].type + " needs water.");
                }
                else
                {
                    Console.WriteLine("The " + flowersAndTrees[i].color + " " + flowersAndTrees[i].type + " doesnt need water.");
                    wateringList.Remove(flowersAndTrees[i]);
                }

            }
            Console.WriteLine();

        }
        public void Water(double wateringAmount)
        {

            double portion = wateringAmount / wateringList.Count;
            for (int i = 0; i < wateringList.Count; i++)
            {
                if (wateringList[i].type == "flower")
                {
                    wateringList[i].waterAmount = wateringList[i].waterAmount + (portion / 100) * 75;
                }

                else
                {
                    wateringList[i].waterAmount = wateringList[i].waterAmount + (portion / 100) * 40;
                }

            }
        }

    }
}
