﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create dictionary with key[name of course] value[list students ascending order]
            //check if course is exist add students or create new one with student
            string end = string.Empty;
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();  
            while ((end = Console.ReadLine()) != "end")
            {
                string[] input = end.Split(" : ",StringSplitOptions.RemoveEmptyEntries);

                if (map.ContainsKey(input[0]))
                {
                    map[input[0]].Add(input[1]);
                }
                else
                {
                    map.Add(input[0], new List<string>());
                    map[input[0]].Add(input[1]);
                }
            }
            //sort map to n.value.count by descending order
            Dictionary<string, List<string>> map2 = 
                map.OrderByDescending(x => x.Value.Count).ToDictionary<string, List<string>>;
            //then sort list of names in map by ascending order and print them

        }
    }
}
