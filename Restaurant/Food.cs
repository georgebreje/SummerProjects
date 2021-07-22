using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum FoodType
    {
        Pizza,
        Pasta,
        Soup,
        Meat,
        SideDish
    }
    public class Food
    {
        public Food() { }

        public void Prepare()
        {
            // when food storage = 0 auto call prepare more food from menu class


        }
    }
}
