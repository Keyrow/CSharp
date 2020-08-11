using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();

        // Buffet Constructor
        public Buffet()
        {
            // add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
            // Follow the parameters from Food.cs
            Menu = new List<Food>()
            {
                new Food("Jalapeno Popper Cheeseburger", 600, true, false),
                new Food("House Salad", 300, false, false),
                new Food("Mango Habenero Wings", 700, true, true),
                new Food("Pepperoni Pizza", 500, false, false),
                new Food("Sweet & Sour Chicken", 800, false, true),
                new Food("Chili & Cheese Fries", 300, false, false),
                new Food("Grilled Chicken Sandwich", 400, false, false),
            };
        }
        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}