using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum DrinkType
    {
        NonAlcoholic,
        Alcoholic,
    }
    public class Drink
    {
        public Dictionary<DrinkType, Dictionary<string, int>>
            DrinkStorage = new Dictionary<DrinkType, Dictionary<string, int>>
            {
                {
                    DrinkType.NonAlcoholic, new Dictionary<string, int>
                    {
                        {"Soda", 15},
                        {"Water", 15},
                        {"Limonade", 15},
                        {"Fresh", 15 }
                    }
                },
                {
                    DrinkType.Alcoholic, new Dictionary<string, int>
                    {
                        {"Wine", 10},
                        {"Beer", 10},
                        {"Palinca", 100}
                    }
                }
            };

        public string Name { get; set; }
        public DrinkType DrinkType { get; set; }
        public Drink() { }
        
        public void AccessStock()
        {
            foreach (KeyValuePair<DrinkType, Dictionary<string, int>> kvp in DrinkStorage)
            {
                Console.WriteLine($"Key = {kvp.Key}");
                foreach (KeyValuePair<string, int> dict in kvp.Value)
                    Console.WriteLine($"Value = {dict}");
            }
        }



    }
}
