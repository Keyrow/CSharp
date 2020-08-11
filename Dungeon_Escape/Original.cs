// THIS IS THE ORIGINAL CODE MADE WITH JAVA THAT I USED TO CONVERT TO C#


/*
import java.util.Scanner;
import java.util.Random;

class DungeonEscape {
  public static void main(String[] args) {
    //timer variables
    long startTime = System.currentTimeMillis();
    long endTime;
    long duration;
    
    int totalDeaths = 0;
    int totalEscapes = 0;
    
    int lives = 3;
    int currentRoom = 1;
    int totalRooms = 10;
    boolean playing = true;

    Scanner scan = new Scanner(System.in);
    Random random = new Random();
    

    System.out.println("-------------------Welcome to Song's Dungeon Escape!-------------------");
    System.out.println("You have 3 lives. The exit is at the end of 10 rooms.");
    System.out.println("But beware... traps may line your path....");
    
    while (playing) {
      //menu parts
      System.out.println();
      System.out.println("Lives: " + lives + "\t\t\t\tRoom: " + currentRoom + "/" + totalRooms);
      System.out.println();
      System.out.println("1 - Left\n2 - Middle\n3 - Right\nQ - Commit Seppuku");
      System.out.print("Which direction do you want to go?  ");
      
      //player choice
      //this step doesn't really even matter since we're just gonna random something anyway. player has no idea what happens in the other two rooms, but this can be fixed later. It will just output some bullshit about progressing through the left/middle/right room
      switch (scan.next().toUpperCase()) {
        case "1":
          System.out.println();
          System.out.println("You've chosen the LEFT path....");
          break;
        case "2":
          System.out.println();
          System.out.println("You've chosen the MIDDLE path....");
          break;
        case "3":
          System.out.println();
          System.out.println("You've chosen the RIGHT path....");
          break;
        case "Q":
          System.out.println();
          System.out.println("You've chosen the COWARD's path!");
          lives = 0;
          break;
        default:
          System.out.println("You must choose a legitimate path!");
          continue;
      } 

      //random choose a room type from 0-2: trap, nothing, healing
      if (lives > 0) {
        switch (random.nextInt(3)) {
          case 0: //trap
            System.out.println("You have encountered a trap! How unlucky. You have lost 1 life.");
            lives--;
            break;
          case 1: //nothing
            //System.out.println("You have encountered nothing... for better or for worse....");
            //encounter 4 chests and force a choosing
            boolean validChoice = false;
            while (!validChoice) {
              System.out.println("You have encountered 4 chests! Open one to move on.");
              System.out.println("1 - Blue Chest\n2 - Red Chest\n3 - Green Chest\n4 - Purple Chest");
              System.out.print("Which chest do you choose?  ");
              switch (scan.next().toUpperCase()) {
                case "1":
                  System.out.println();
                  System.out.println("You've chosen the BLUE chest....");
                  validChoice = true;
                  break;
                case "2":
                  System.out.println();
                  System.out.println("You've chosen the RED chest....");
                  validChoice = true;
                  break;
                case "3":
                  System.out.println();
                  System.out.println("You've chosen the GREEN chest....");
                  validChoice = true;
                  break;
                case "4":
                  System.out.println();
                  System.out.println("You've chosen the PURPLE chest....");
                  validChoice = true;
                  break;
                default:
                  System.out.println("You must choose a legitimate chest!");
                  continue;
              } 
            }

            //outcomes from choosing chests
            switch(random.nextInt(4)) {
              case 0:
                System.out.println("You have inhaled poison gas! You have lost 1 life.");
                lives--;
                break;
              case 1:
                System.out.println("You have been struck by an arrow trap! You have lost 1 life.");
                lives--;
                break;
              case 2:
                if (currentRoom == totalRooms) {
                  System.out.println("The chest explodes and so you do! You have died. So close....");
                  lives = 0;
                  break;
               }
                System.out.println("The chest had nothing! Too bad... for you....");
                break;
              case 3:
                System.out.println("The chest had a healing potion! You have gained 1 life!");
                lives++;
                break;
            }
            break;
          case 2: //healing
            System.out.println("You have encountered a healing room! Lucky schmuck. You have gained 1 life.");
            lives++;
            break;
        }
      }

      if (lives <= 0) {
        System.out.println();
        System.out.println("Game over! You died in room " + currentRoom + ". No more lives...");
        totalDeaths++;
        boolean validChoice = false;
        while (!validChoice) {
          System.out.println("Play again?");
          System.out.println("Y | N");
          switch (scan.next().toUpperCase()) {
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
              System.out.println("Invalid choice!");
              break;
          }
        }
      } else {
        currentRoom++;
      }

      if (currentRoom > totalRooms) {
        System.out.println();
        System.out.println("Congratulations, you won! You have escaped with " + lives + " lives!");
        totalEscapes++;
        boolean validChoice = false;
        while (!validChoice) {
          System.out.println("Play again?");
          System.out.println("Y | N");
          switch (scan.next().toUpperCase()) {
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
              System.out.println("Invalid choice!");
              break;
          }
        }
      }
    }
    scan.close();
    endTime = System.currentTimeMillis();
    duration = (endTime - startTime) / 1000;

    System.out.println("Thank you for playing Gen Eric's Dungeon Escape!");
    System.out.println("Total play time: " + duration + " seconds");
    System.out.println("Total escapes: " + totalEscapes);
    System.out.println("Total deaths: " + totalDeaths);
  }
}
*/