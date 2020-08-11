using System;

namespace Dungeon_Escape
{
    class Program
    {
        class DungeonEscape
        {
            public static void Main(String[] args)
            {
                //timer variables
                // long startTime = System.currentTimeMillis();
                // long endTime;
                // long duration;

                int totalDeaths = 0;
                int totalEscapes = 0;

                int lives = 3;
                int currentRoom = 1;
                int totalRooms = 10;
                bool playing = true;

                Random random = new Random();

                System.Console.WriteLine("-------------------Welcome to Song's Dungeon Escape!-------------------", Console.ForegroundColor = ConsoleColor.Blue);
                Console.ResetColor();
                System.Console.WriteLine("You have 3 lives. The exit is at the end of 10 rooms.");
                System.Console.WriteLine("But beware... traps may line your path....");
                System.Console.WriteLine("This version has an approxamately 20% survival rate... May RNG be with you, Good Luck...");

                while (playing)
                {
                    //menu parts
                    System.Console.WriteLine("Lives: " + lives + "\t\t\t\tRoom: " + currentRoom + "/" + totalRooms);
                    System.Console.WriteLine("1 - Left\n2 - Middle\n3 - Right\n4 - Commit Seppuku");
                    System.Console.WriteLine("Which direction do you want to go?  ");
                    String direction = (Console.ReadLine());
                    //player choice
                    //this step doesn't really even matter since we're just gonna random something anyway. player has no idea what happens in the other two rooms, but this can be fixed later. It will just output some bullshit about progressing through the left/middle/right room
                    switch (direction)
                    {
                        case "1":
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("You've chosen the LEFT path....");
                            break;
                        case "2":
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("You've chosen the MIDDLE path....");
                            break;
                        case "3":
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("You've chosen the RIGHT path....");
                            break;
                        case "4":
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("You've chosen the COWARD's path!", Console.ForegroundColor = ConsoleColor.Red);
                            lives = 0;
                            Console.ResetColor();
                            break;
                        default:
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            System.Console.WriteLine("You must choose a legitimate path!", Console.ForegroundColor = ConsoleColor.DarkYellow);
                            Console.ResetColor();
                            continue;
                    }

                    //random choose a room type from 0-2: trap, nothing, healing
                    if (lives > 0)
                    {
                        switch (random.Next(3))
                        {
                            case 0: //trap
                                System.Console.WriteLine("You have encountered a trap! How unlucky. You have lost 1 life.", Console.ForegroundColor = ConsoleColor.Red);
                                lives--;
                                Console.ResetColor();
                                break;
                            case 1: //nothing
                                    //System.out.println("You have encountered nothing... for better or for worse....");
                                    //encounter 4 chests and force a choosing
                                bool validChoice = false;
                                while (!validChoice)
                                {
                                    System.Console.WriteLine("You have encountered 4 chests! Open one to move on.");
                                    System.Console.WriteLine("1 - Blue Chest\n2 - Red Chest\n3 - Green Chest\n4 - Yellow Chest");
                                    System.Console.WriteLine("Which chest do you choose?  ");
                                    string choice = Console.ReadLine();
                                    // int number;
                                    // bool isValidNumber = Int32.TryParse(choice, out number);
                                    switch (choice)
                                    {
                                        case "1":
                                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                            System.Console.WriteLine("You've chosen the BLUE chest....", Console.ForegroundColor = ConsoleColor.Blue);
                                            validChoice = true;
                                            Console.ResetColor();
                                            break;
                                        case "2":
                                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                            System.Console.WriteLine("You've chosen the RED chest....", Console.ForegroundColor = ConsoleColor.Red);
                                            validChoice = true;
                                            Console.ResetColor();
                                            break;
                                        case "3":
                                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                            System.Console.WriteLine("You've chosen the GREEN chest....", Console.ForegroundColor = ConsoleColor.Green);
                                            validChoice = true;
                                            Console.ResetColor();
                                            break;
                                        case "4":
                                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                            System.Console.WriteLine("You've chosen the YELLOW chest....", Console.ForegroundColor = ConsoleColor.Yellow);
                                            validChoice = true;
                                            Console.ResetColor();
                                            break;
                                        default:
                                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                            System.Console.WriteLine("You must choose a legitimate chest!");
                                            continue;
                                    }
                                }

                                //outcomes from choosing chests
                                switch (random.Next(4))
                                {
                                    case 0:
                                        System.Console.WriteLine("The chest released a poison gas! You have lost 1 life.", Console.ForegroundColor = ConsoleColor.Red);
                                        lives--;
                                        Console.ResetColor();
                                        break;
                                    case 1:
                                        System.Console.WriteLine("Opening this chest triggers an arrow trap at you! You have lost 1 life.", Console.ForegroundColor = ConsoleColor.Red);
                                        lives--;
                                        Console.ResetColor();
                                        break;
                                    case 2:
                                        if (currentRoom == totalRooms)
                                        {
                                            System.Console.WriteLine("The chest explodes and so do you! You have died. So close....", Console.ForegroundColor = ConsoleColor.Cyan);
                                            lives = 0;
                                            Console.ResetColor();
                                            break;
                                        }
                                        System.Console.WriteLine("You open the chest only to find a lot of spiders trapped inside and crawls out lunging and bites you! You have lost a life", Console.ForegroundColor = ConsoleColor.Red);
                                        lives--;
                                        Console.ResetColor();
                                        break;
                                    case 3:
                                        System.Console.WriteLine("You open this chest and found a healing potion! You have gained 1 life.", Console.ForegroundColor = ConsoleColor.Green);
                                        lives++;
                                        Console.ResetColor();
                                        break;
                                }
                                break;
                            case 2: //healing
                                System.Console.WriteLine("You entered the room which has a mysterious lingering mist... You start feeling a lot better, you have gained 1 life.", Console.ForegroundColor = ConsoleColor.Green);
                                lives++;
                                Console.ResetColor();
                                break;
                        }
                    }

                    if (lives <= 0)
                    {
                        System.Console.WriteLine("Game over! You died in room " + currentRoom + ". No more lives...", Console.ForegroundColor = ConsoleColor.DarkRed);
                        totalDeaths++;
                        Console.ResetColor();
                        bool validChoice = false;
                        while (!validChoice)
                        {
                            System.Console.WriteLine("Play again?");
                            System.Console.WriteLine("Y | N");
                            String play = Console.ReadLine();
                            switch (play.ToUpper())
                            {
                                case "Y":
                                    lives = 3;
                                    currentRoom = 1;
                                    validChoice = true;
                                    break;
                                case "N":
                                    playing = false;
                                    validChoice = true;
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        currentRoom++;
                    }

                    if (currentRoom > totalRooms)
                    {
                        System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        System.Console.WriteLine("Congratulations, you won! You have escaped with " + lives + " lives!", Console.ForegroundColor = ConsoleColor.DarkGreen);
                        Console.ResetColor();
                        totalEscapes++;
                        bool validChoice = false;
                        while (!validChoice)
                        {
                            System.Console.WriteLine("Play again?");
                            System.Console.WriteLine("Y | N");
                            String play = Console.ReadLine();
                            switch (play.ToUpper())
                            {
                                case "Y":
                                    lives = 3;
                                    currentRoom = 1;
                                    validChoice = true;
                                    break;
                                case "N":
                                    playing = false;
                                    validChoice = true;
                                    break;
                                default:
                                    System.Console.WriteLine("Invalid choice!");
                                    break;
                            }
                            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        }
                    }
                }
                // scan.close();
                // endTime = System.currentTimeMillis();
                // duration = (endTime - startTime) / 1000;
                System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                System.Console.WriteLine("Thank you for playing the most generic Dungeon Escape!" + "\n" + "I hope you learned your lesson and not to accept a spiked drink from a stranger causing you to get kidnapped to here!");
                // System.Console.WriteLine("Total play time: " + duration + " seconds");
                System.Console.WriteLine("Total escapes: " + totalEscapes);
                System.Console.WriteLine("Total deaths: " + totalDeaths);
            }
        }
    }
}
