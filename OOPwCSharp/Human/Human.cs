using System;
using System.Collections.Generic;

namespace Human
{


    public class Human
    {
        // Fields
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human()
        {
            // Default Parameters
            Name = "Bob";
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string n, int STR, int INT, int DEX, int HP)
        {
            Name = n;
            Strength = STR;
            Intelligence = INT;
            Dexterity = DEX;
            health = HP;
        }
        // Build Attack method
        public void attack(Human player)
        {
            player.health -= 5 * Strength;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Adding a value to the object; then passes it to the constructorcopy

            // Player with default values
            Human human1 = new Human("Song", 3, 3, 3, 100);
            Console.WriteLine("Player name: " + human1.Name + "\n" +
            "Player's Strength: " + human1.Strength + "\n" +
            "Player's Intelligence: " + human1.Intelligence + "\n" +
            "Players Dexterity: " + human1.Dexterity + "\n" +
            "Player's Health: " + human1.Health);

            // Divider
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Player with custom values
            Human human2 = new Human("Denys", 5, 9999, 5, 5000);
            Console.WriteLine("Player name: " + human2.Name + "\n" +
            "Player's Strength: " + human2.Strength + "\n" +
            "Player's Intelligence: " + human2.Intelligence + "\n" +
            "Players Dexterity: " + human2.Dexterity + "\n" +
            "Player's Health: " + human2.Health);

            // Divider
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Player with custom values
            Human human3 = new Human("Hunter", 1, 1, 1, 10);
            Console.WriteLine("Player name: " + human3.Name + "\n" +
            "Player's Strength: " + human3.Strength + "\n" +
            "Player's Intelligence: " + human3.Intelligence + "\n" +
            "Players Dexterity: " + human3.Dexterity + "\n" +
            "Player's Health: " + human3.Health);

            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Attack invoked
            human2.attack(human3);
            System.Console.WriteLine("Player: " + human2.Name + " attacks Player: " + human3.Name + "\n" +
            "Player: " + human3.Name + " Health is now at: " + human3.Health);
            System.Console.WriteLine(human1.Name + " watches the fight in amusement.");
        }
    }
}