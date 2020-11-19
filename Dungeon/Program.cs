using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DUNGEON OF DYSFUNCTION\n");
            Console.WriteLine("Let's begin...");

            int score = 0;

            //TODO 1. Create a Player - need to learn about custom classes
            //TODO Create Player Inventory to store weapon

            //TODO 2. Create a Weapon
            Weapons lSword1 = new Weapons(12, 1, 16, 60, "Long Sword", false, true);
            Weapons lSword2 = new Weapons(12, 1, 16, 60, "Enchanted Long Sword", true, true);
            Weapons sSword1 = new Weapons(10, 1, 13, 45, "Short Sword", false, false);
            Weapons sSword2 = new Weapons(10, 1, 13, 45, "Enchanted Short Sword", true, false);
            Weapons axe1 = new Weapons(5, 1, 7, 10, "Woodcutter's Axe", false, false);
            Weapons axe2 = new Weapons(20, 1, 25, 120, "Axe of Paul Bunyan", true, true);

            Weapons[] weapons = { lSword1, lSword2, sSword1, sSword2, axe1, axe2 };

            //TODO try to add special attributes based off of the race
            Player p1 = new Player("Ralphie", 75, 16, 100, 100, Race.Khajit, lSword2);
            Player p2 = new Player("Stan", 45, 13, 50, 50, Race.Human, sSword1);
            Player p3 = new Player("Lance", 50, 14, 55, 55, Race.Halfling, lSword1);
            Player p4 = new Player("Fallon", 65, 15, 70, 70, Race.Elf, lSword1);
            Player p5 = new Player("Randy", 55, 14, 85, 85, Race.Orc, axe2);
            Player p6 = new Player("Landon", 65, 15, 75, 75, Race.Dwarf, axe1);
            Player p7 = new Player("Danny", 65, 15, 35, 35, Race.Human, lSword1);

            Player[] players = { p1, p2, p3, p4, p5, p6, p7 };

            Random rand = new Random();
            int randomNbr = rand.Next(players.Length);
            Player player = players[randomNbr];
            //TODO Create a function that lowers the durability of a weapon based off of the damage it gave. Have it break once duribility = 0.

            //TODO 3. Create a loop for the room and monster
            bool exit = false;

            //Make Expandable Collection (list) of weapon that the player has.
            //
            do
            {
                //Create Room
                Console.WriteLine(GetRoom());
                //Generate treasure (string describing piece of treasure - variable)
                //string currentTreasure = GetTreasure();
                //Create the Monsters
                Dragon d1 = new Dragon();
                Dragon d2 = new Dragon("Roger", 50, 50, 35, 15, 4, 12, "Look at the red scales on that huge dragon!", true, false);
                Dragon d3 = new Dragon("Samson", 50, 50, 35, 20, 4, 12, "Look at the blue scales on that huge dragon!", false, true);
                Slime s1 = new Slime();
                Slime s2 = new Slime("Fire Slime", 30, 30, 20, 20, 5, 15, "That slime is glowng red... Maybe I should watch out.", true);

                //TODO 4. Create a Menu of Options
                bool reload = false;
                do
                {
                    #region Menu Loop


                    Console.WriteLine("\n\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n" +
                        "Score: {0}\n\n",
                        score);

                    //TODO 5. Catch the user choice
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    //TODO 6. Clear the Console
                    Console.Clear();

                    //TODO 7. Build out the switch that determines what functionality the user wants
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Player Attacks!");
                            //TODO 8. Handle the Attack Sequence
                            //TODO 9. Handle if the player wins
                            //currentTreasure.Add()
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!");
                            //TODO 10. Monster gets a free attack
                            //TODO 11. Exit the inner loop and get a new moster/room
                            reload = true;//exit the inner loop and get a new room for the monster
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info\n");
                            //TODO 12.Print out the player info
                            //Console.WriteLine(player info);
                            //foreach for printing collection to console
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info\n");
                            //TODO 13. Print out the monster info
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("Nobody like a quitter! Be gone!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Thou hast chosen improperly...triest thou again!");
                            break;
                    }
                    #endregion

                    //TODO 14. Check the player's life points before continuing

                } while (!exit && !reload);


            } while (!exit);//exit the program

            //Tell the user the game has ended and give them their score.
            //Ternary operator
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

        }//end main

        private static string GetRoom()
        {
            string[] rooms =
            {
                "You have entered a dark room. Slime oozes down the white walls and slowly spreads itself on the brown, hardwood floor.",
                "You walk into what looks like a very clean bathroom. The surfaces all sparkle as though they had just been cleaned.",
                "This room is hung with hundreds of dusty tapestries. All show signs of wear: moth holes, scorch marks, dark stains, and the damage of years of neglect. They hang on all the walls and hang from the ceiling to brush against the floor, blocking your view of the rest of the room.",
                "A dozen statues stand or kneel in this room, and each one lacks a head and stands in a posture of action or defense. All are garbed for battle. It's difficult to tell for sure without their heads, but two appear to be dwarves, one might be an elf, six appear human, and the rest look like they might be orcs.",
                "Thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a wind you can barely feel. One corner of the ceiling has a particularly large clot of webbing within which a goblin's bones are tangled.",
                "A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room.",
                "Sunshine blids you as you walk into a room full of windows. There is no air flow; so, you begin to feel over heated.",
                "The scent of earthy decay assaults your nose upon peering through the open door to this room. Smashed bookcases and their sundered contents litter the floor. Paper rots in mold-spotted heaps, and shattered wood grows white fungus.",
                "This small bare chamber holds nothing but a large ironbound chest, which is big enough for a man to fit in and bears a heavy iron lock. The floor has a layer of undisturbed dust upon it."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = "******NEW ROOM******\n" +
                rooms[indexNbr] + "\n";

            return room;
        }

    }
}

