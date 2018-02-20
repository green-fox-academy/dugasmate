﻿using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var listed = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var inputList = new List<int> {  4, 8, 12, 16 };
            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(listed, inputList));
            Console.ReadLine();

        }
        static string CheckNums(List<int> listed, List<int> inputList)
        {
            string output = "";
            for (int i = 0; i < inputList.Count; i++)
            {
                if (listed.Contains(inputList[i]))
                {
                    output = "true";
                }
                else if (!listed.Contains(inputList[i]))
                {
                    output = "false";
                    break;
                }
            }
            return output;
        }
    }
}