using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        private int calorieLimit;
        public List<Food> FoodHistory;
        // add a public "getter" property called "IsFull" F
        public bool IsFull
        {
            get
            {
                return calorieIntake >= calorieLimit;
            }
        }
        // add a constructor
        public Ninja(int c)
        {
            this.calorieIntake = 0;
            this.calorieLimit = c;
            this.FoodHistory = new List<Food>();
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if (this.IsFull)
            {
                // throw exception if the Ninja is too full to eat
                System.Console.WriteLine("Ninja is full, cannot eat anymore or will throw up!");
            }
            else
            {
                System.Console.WriteLine($"Ninja Apprentice Song is about to eat {item.Name}. Spicy: {item.IsSpicy}. Sweet: {item.IsSweet}");
                this.calorieIntake += item.Calories;
                this.FoodHistory.Add(item);
            }
        }
    }
}