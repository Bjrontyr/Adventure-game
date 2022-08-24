namespace Adventure_game__The_Conquest_of_Grung_Gandazak_
{
    using System.Collections.Generic;

    public static class Game
    {
        //All game related choices and objects
        static string? CharacterName = "Gotrek";
        static List<string> Inventory = new List<string>();

        //====================================================================================================================================================================================
        // Below this line are repeatable methods or none-room game stuff! So the Grumbler, Title screen, Inventory list, stuff like that!

        public static Action<string> ww = Console.WriteLine;
         
 
        public static void Dialogue(string message, string color)
        {
            //Method for Dialogue: Used for when the main character or other characters speak.
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (color == "cyan")
            { Console.ForegroundColor = ConsoleColor.Cyan; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Grumbler()
        {
            //Grumble generator
            String[] Grumble1 = { "grouse", "complain", "moan", "bitch", "whine", "bleat", "protest", "grumble", "fuss", "bellyache", "bemoan", "stink", "rail on", "fume" };
            String[] Grumble2 = { "Beardlings", "Grobi", "Urki", "Skaven", "Bankers", "Miners", "Brewers", "knife-ears", "Merchants", "Thaggoraki", "Ogres", "Snotlings" };
            String[] Grumble3 = { "tougher", "hardier", "stronger", "faster", "weaker", "smaller", "bigger", "dumber", "smarter", "broader", "more fulfiling", "more beastly", };
            Random rand = new Random();
            int G1 = rand.Next(Grumble1.Length);
            int G2 = rand.Next(Grumble2.Length);
            int G3 = rand.Next(Grumble3.Length);
            Console.WriteLine($"You " + Grumble1[G1] + " that " + Grumble2[G2] + " were " + Grumble3[G3] + " in your day!");

        }
        public static void Title()
        {
            //Title sequence goes here
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("+=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=+");
            Console.WriteLine("         The Conquest of Grung Gandazak         ");
            Console.WriteLine("+=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=++=+=+");
            Console.WriteLine("Press Enter to Start.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Startgame()
        {
            Console.ResetColor();
            Console.WriteLine(" Hullo manlings! Welcome to my short choose your own adventure Game!");
            Console.WriteLine(" This adventure game takes place in the Warhammer Fantasy Roleplay setting and thus should be familliar to most of you!");
            Console.WriteLine(" I hope you enjoy! ");
            NameCharacter();
        }
        public static void NameCharacter()
        {
            Console.WriteLine("To begin would you tell me,what is your Dwarven name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Hail " + CharacterName + " and welcome to the mines of your hold.");
            Console.WriteLine("Press Enter To Continue.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Intro()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You are a Dwarf. You have spent your life toiling in the mines deep below your ancestral home of Karak Hirn: The Hornhold. ");
            Console.WriteLine("Last winter, you and your mates were swilling a pint of Bugmans at the tavern when Snorri, your mining captain, had an idea.");
            Game.Dialogue("\"Lads, me cousin has just headed north up the Spinehorn to establish a mine. He says he's found a large vein of silver and that he could use some good beards to excavate it!\"", "cyan");
            Console.WriteLine("You all jumped at the prospect to strike out on your own and found a new Grung for the glory of the hold! So off you went...Though now you wish you hadn't.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadKey();
            Console.Clear();
            Day178();

        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Initial scene where the player awakes in the hearth of the barracks.
        public static void Day178()
        {
            Console.WriteLine("__________ Day 178 of the Siege of Grung Gandazak____________");
            Console.WriteLine("You awake with a start. You made your bed inside the hearth in the barracks with the heavy iron grate closed for some protection.");
            Console.WriteLine("You can't hear any signs of battle, nor the scrabbling of clawed feet on stone. Perhaps the barracks is still clear and you may yet be able to find the rest of your mining team.");
            Console.WriteLine("Or at the very least what might be left of them.");
            Game.Dialogue("\"Blasted Thaggoraki,cursed, wretched, skum. My axe will bite into each one of them before the day is done.\"", "cyan");
            Console.WriteLine("You say aloud to yourself.");
            Game.ChoiceDay178();
        }
        public static void ChoiceDay178()
        {
            string? PlayerChoice = "";
            Console.WriteLine("What do you want to do? 1)Grab your axe and push aside the grate? 2) Stay in bed and sleep some more? 3)Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                Console.WriteLine("You grab hold of your axe and push aside the grate! Rolling from the hearth and finding your feet in the barracks.");
                Console.WriteLine("Axe has been added to your inventory.");
                Inventory.Add("Axe");
                Console.WriteLine("Press Enter to Continue.");
                Console.Clear();
                Game.Barracksstart();
            }
            else if (PlayerChoice == "2")
            {
                Console.WriteLine("You decide to sleep a little longer, slaying Skaven can wait and you're a lazy wazzok!");
                Console.WriteLine("What would you like to do next " + CharacterName + "?");
                Game.ChoiceDay178();

            }
            else if (PlayerChoice == "3")
            {
                Game.Grumbler();
                Console.WriteLine("What would you like to do next " + CharacterName + "?");
                Game.ChoiceDay178();


            }
            // Choice tree for the player to enter the barracks and start the game.
            //-------------------------------------------------------------------------------------------------------------------------------------------------------

        }
        //============================================================================================================================================================================================
        // Players initial scene upon leaving the hearth. This is the "starting" scene and thus there's another barracks room later so as to not confuse the two and create a huge mess.
        public static void Barracksstart()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Placing your feet back on solid stone, you stretch and shake off the coal dust that had gathered on you from the musty hearth.");
            Console.WriteLine("The barracks is in a sorry state these days. The door is barricaded by ruined furniture, the tiled floor is flecked with stains of blood,");
            Console.WriteLine("and the dead body of your dear friend Gorgsson lies against the right hand wall, his shield still intact, held aloft by the remains of his smashed arm.");
            Console.WriteLine("His glorious long gray beard, beautifully braided with silver ornamnets is now sullied and matted, stained with his blood.");
            Console.WriteLine("You shake your head.");
            Game.Dialogue("\"I'm sorry old friend, you will be avenged.\"", "cyan");
            Console.WriteLine("The walls of this once proud hall are still carved with murals of it's founding, though the back wall has a particularly large crack in it.");
            Console.WriteLine("The room is perhaps 20 paces long and 15 paces wide, enough to accomodate each dwarf and their beds in better times.");
            Console.WriteLine("You wince as you start to wander the room, looking down at the torn blanket that binds the splint to your wounded leg.");
            Game.Dialogue("\"Won't be slaying any rats without a little advantage! Grimnir preserve me the bastard that stuck be better have perished from my axe blow!\"", "cyan");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("What would you like to do " + CharacterName + "?.");
            if (Inventory.Contains("nonsenseplsignoreinitialtestofcodef"))
            {
                Game.Barracksstartchoice();
                //you can ignore this initial choice I left it here for reference while I was learning.
                //Basically just an inventory check to determine which scene to use.
            }
            else if (Inventory.Contains("Axe"))
            {
                Game.Barracksstartchoicetwo();
                //Actual main choice sequence.
            }

        }
        public static void Barracksstartchoice()
        {
            Console.WriteLine("Failure");
            //continuation of learning reference
        }
        public static void Barracksstartchoicetwo()
        {
            string? Playerchoice = "";
            Console.WriteLine("Would you like to: 1)Investigate Gorgssons body? 2)Investigate the crack in the wall? 3)Remove the barricade from the door and proceed into the hallway? 4) Grumble?");
            Playerchoice = Console.ReadLine();
            if (Playerchoice == "1")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You take a closer look at Gorgssons body. You realize that you could take the shield he is carrying, given he won't be needing it.");
                Console.WriteLine("It seems that Gorgsson has a journal attached to his belt, perhaps you could read it?");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(CharacterName + " Would you like to: 1) Take Gorggssons shield? 2) Read Gorggssons journal? 3) Return to the room?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {
                    Console.WriteLine("You pick up Gorggssons shield.");
                    Inventory.Add("Shield");
                    Game.Barracksstartchoicetwo();
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You take the journal from Gorgssons belt and open it's pages.");
                    Game.Dialogue("\"To whom it may concern, you are reading the final words and wishes of Grungadin Gorggsson of Karak Hirn. Written within these pages you will find my final grudge.\"", "cyan");
                    Game.Dialogue("\"I wish a great reckoning to come to the Skaven that infest Grung Gandazak and I wish that Reckoning done by Dwarf hands.\"", "cyan");
                    Game.Dialogue("\"Further, I should hope that the remains of all Dwarves within the Grung be located and any potential survivors helped to saftey.\"", "cyan");
                    Game.Dialogue("\"Finally, the mines of this hold must be sealed, for the good of all Dwarvenkind.\"", "cyan");
                    Console.WriteLine("The Journals pages say nothing else.");
                    Console.WriteLine("Each character was written in blood, a binding seal of great power amongst Dwarven kind. This grudge must be answered and it must be done by you.");
                    Console.WriteLine("You take the journal with you on your journey.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Inventory.Add("Gorggssonsjournal");
                    Game.Barracksstartchoicetwo();

                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You pay your respects and go back to examing the barracks.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barracksstartchoicetwo();
                }
            }
            else if (Playerchoice == "2")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                Game.Dialogue("\"Hmmm, I'll need to be well prepared to go in there, perhaps there's some way I could open up this crack and get the drop on them!\"", "cyan");
                Game.Dialogue("\"Of course, even with the element of surprise I'll need to be well armed and ready!\"", "cyan");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.Barracksstartchoicetwo();
            }
            else if (Playerchoice == "3")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You carefully and quietly move aside the barricade of broken furniture you placed in front of the Barracks door and walk into the hallway.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.Bar2Kit();

            }
            else if (Playerchoice == "4")
            {
                Game.Grumbler();
                Game.Barracksstartchoicetwo();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // End of Starting Barracks choices, from here the player will continue onto the other rooms.

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Later Barracks choices below for if the player returns to the barracks later.
        // Create a seperate method for Gorggssons body to be held in the barracks
        // 
        public static void Barracks()
        {
            // Return to barracks scene
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You open the door and enter the barracks.");
            Console.WriteLine("The barracks is in a sorry state these days. Ruined furniture is strewn about the room from when you removed the barricade and the tiled floor is flecked with stains of blood.");
            Console.WriteLine("The dead body of your dear friend Gorgsson lies against the right hand wall, his glorious long gray beard braided with silver ornamnets now stained with his blood. ");
            Console.WriteLine("You shake your head.");
            Game.Dialogue("\"I'm sorry old friend, you will be avenged.\"", "cyan");
            Console.WriteLine("The walls of this once proud hall are still carved with murals of it's founding, though the back wall has a particularly large crack in it.");
            Console.WriteLine("The room is perhaps 20 paces long and 15 paces wide, enough to accomodate each dwarf and their beds in better times.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            //Choices will include the abillity to leave the room, to grumble, to interact with the body and crack, and in different ways based on items.
            Console.WriteLine("What would you like to do " + CharacterName + "?.");
            Game.Barrackschoice();

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Choice tree for the Barracks.
        public static void Barrackschoice()
        {
            //Choice tree for if the player returns to the barracks later in the game.
            string? Playerchoice = "";

            if (Inventory.Contains("Shield") && Inventory.Contains("Gorggssonsjournal") && Inventory.Contains("Blackpowder") && Inventory.Contains("Guns"))
            //"Shield Gorggssonsjournal Blackpowder Guns
            {
                Console.WriteLine("Would you like to: 1)Pay your respects to Gorggsson? 2)Investigate the crack in the wall? 3)Go back to the hallway? 4) Grumble?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You say invoke the name of Grimnir and make certain that Gorggssons hand rests firmly on the pommel of his weapon.");
                    Game.Dialogue("\"We'll bury you old friend, just as sooon as my work here is done.\"", "cyan");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barrackschoice();
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                    Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                    Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                    Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                    Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                    Console.WriteLine("You could use the Blackpowder barrel you've gathered to blow a hole in the wall!");
                    Console.WriteLine("and that brace of fine Dwarven pisols you took earlier should give you a nice advantage in all the commotion!");
                    //Ask the player if they would like to blow up the wall and attack, if yes they do so and are succesful.
                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("You decide to return to the hallway.");
                    Game.Bar2Kit();
                }
                else if (Playerchoice == "4")
                {
                    Game.Grumbler();
                    Game.Barrackschoice();
                }

            }
            else if (Inventory.Contains("Shield") & !Inventory.Contains("Gorggssonsjournal"))
            {
                //inevstigate the body and take journal
                Console.WriteLine("Would you like too: 1)Take the journal from Gorggssons body? 2)Investigate the crack in the wall? 3)Return to the hallway? 4)Grumble?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {

                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You take the journal from Gorgssons belt and open it's pages.");
                    Game.Dialogue("\"To whom it may concern, you are reading the final words and wishes of Grungadin Gorggsson of Karak Hirn. Written within these pages you will find my final grudge.\"", "cyan");
                    Game.Dialogue("\"I wish a great reckoning to come to the Skaven that infest Grung Gandazak and I wish that Reckoning done by Dwarf hands.\"", "cyan");
                    Game.Dialogue("\"Further, I should hope that the remains of all Dwarves within the Grung be located and any potential survivors helped to saftey.\"", "cyan");
                    Game.Dialogue("\"Finally, the mines of this hold must be sealed, for the good of all Dwarvenkind.\"", "cyan");
                    Console.WriteLine("The Journals pages say nothing else.");
                    Console.WriteLine("Each character was written in blood, a binding seal of great power amongst Dwarven kind. This grudge must be answered and it must be done by you.");
                    Console.WriteLine("You take the journal with you on your journey.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Inventory.Add("Gorggssonsjournal");

                    Game.Barrackschoice();
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                    Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                    Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                    Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                    Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                    Game.Dialogue("\"Hmmm, I'll need to be well prepared to go in there, perhaps there's some way I could open up this crack and get the drop on them!\"", "cyan");
                    Game.Dialogue("\"Of course, even with the element of surprise I'll need to be well armed and ready!\"", "cyan");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barrackschoice();
                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("You decide to return to the hallway.");
                    Game.Bar2Kit();
                }
                else if (Playerchoice == "4")
                {
                    Game.Grumbler();
                    Game.Barrackschoice();
                }
            }
            else if (Inventory.Contains("Gorggssonsjournal") & !Inventory.Contains("Shield"))
            {
                //investigate the body and take shield
                Console.WriteLine("Would you like too: 1)Take the Shield from Gorggssons body? 2)Investigate the crack in the wall? 3)Return to the hallway? 4)Grumble?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {

                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You take Gorggssons Shield with you as it's still perfectly useable.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Inventory.Add("Shield");

                    Game.Barrackschoice();
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                    Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                    Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                    Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                    Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                    Game.Dialogue("\"Hmmm, I'll need to be well prepared to go in there, perhaps there's some way I could open up this crack and get the drop on them!\"", "cyan");
                    Game.Dialogue("\"Of course, even with the element of surprise I'll need to be well armed and ready!\"", "cyan");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barrackschoice();
                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("You decide to return to the hallway.");
                    Game.Bar2Kit();
                }
                else if (Playerchoice == "4")
                {
                    Game.Grumbler();
                    Game.Barrackschoice();
                }

            }
            else if (Inventory.Contains("Blackpowder") && Inventory.Contains("Guns") & !Inventory.Contains("Shield") & !Inventory.Contains("Gorggssonsjournal"))
            {
                // investigate the body and take both the shield and the journal + forge attack
                Console.WriteLine("Would you like to: 1)Investigate Gorgssons body? 2)Investigate the crack in the wall? 3)Remove the barricade from the door and proceed into the hallway? 4) Grumble?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You take a closer look at Gorgssons body. You realize that you could take the shield he is carrying, given he won't be needing it.");
                    Console.WriteLine("It seems that Gorgsson has a journal attached to his belt, perhaps you could read it?");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(CharacterName + " Would you like to: 1) Take Gorggssons shield? 2) Read Gorggssons journal? 3) Return to the room?");
                    Playerchoice = Console.ReadLine();
                    if (Playerchoice == "1")
                    {
                        Console.WriteLine("You pick up Gorggssons shield.");
                        Inventory.Add("Shield");
                        Game.Barrackschoice();
                    }
                    else if (Playerchoice == "2")
                    {
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("You take the journal from Gorgssons belt and open it's pages.");
                        Game.Dialogue("\"To whom it may concern, you are reading the final words and wishes of Grungadin Gorggsson of Karak Hirn. Written within these pages you will find my final grudge.\"", "cyan");
                        Game.Dialogue("\"I wish a great reckoning to come to the Skaven that infest Grung Gandazak and I wish that Reckoning done by Dwarf hands.\"", "cyan");
                        Game.Dialogue("\"Further, I should hope that the remains of all Dwarves within the Grung be located and any potential survivors helped to saftey.\"", "cyan");
                        Game.Dialogue("\"Finally, the mines of this hold must be sealed, for the good of all Dwarvenkind.\"", "cyan");
                        Console.WriteLine("The Journals pages say nothing else.");
                        Console.WriteLine("Each character was written in blood, a binding seal of great power amongst Dwarven kind. This grudge must be answered and it must be done by you.");
                        Console.WriteLine("You take the journal with you on your journey.");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Inventory.Add("Gorggssonsjournal");
                        Game.Barrackschoice();

                    }
                    else if (Playerchoice == "3")
                    {
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("You pay your respects and go back to examing the barracks.");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                        Game.Barrackschoice();
                    }
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                    Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                    Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                    Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                    Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                    Console.WriteLine("You could use the Blackpowder barrel you've gathered to blow a hole in the wall!");
                    Console.WriteLine("and that brace of fine Dwarven pisols you took earlier should give you a nice advantage in all the commotion!");
                    //Ask the player if they would like to blow up the wall and attack, if yes they do so and are succesful.
                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You carefully and quietly move aside the barricade of broken furniture you placed in front of the Barracks door and walk into the hallway.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Bar2Kit();

                }
                else if (Playerchoice == "4")
                {
                    Game.Grumbler();
                    Game.Barrackschoice();
                }
            }
            else if (Inventory.Contains("Shield") && Inventory.Contains("Gorggssonsjournal"))
            {
                //pay respects and get the hint from investigating the wall
                Console.WriteLine("Would you like to: 1)Pay your respects to Gorggsson? 2)Investigate the crack in the wall? 3)Go back to the hallway? 4) Grumble?");
                Playerchoice = Console.ReadLine();
                if (Playerchoice == "1")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You say invoke the name of Grimnir and make certain that Gorggssons hand rests firmly on the pommel of his weapon.");
                    Game.Dialogue("\"We'll bury you old friend, just as sooon as my work here is done.\"", "cyan");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barrackschoice();
                }
                else if (Playerchoice == "2")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You wander to the back wall to have a peek at the crack.");
                    Console.WriteLine("The Crack is rather large being at least as tall as you are and has many smaller cracks cascading from it along the wall.");
                    Game.Dialogue("\"Welp. That's certain to undemermine the structurally integrity of the room!\"", "cyan");
                    Console.WriteLine("You can hear some Skaven squeaking and talking amongst themselves! They must be just in the next room over, which should be the Forge!");
                    Console.WriteLine("Placing your eye to the crack, you can just barely see the outline of a few figures in the dark room, perhaps as many as a dozen, with one being a little larger than the rest.");
                    Game.Dialogue("\"Hmmm, I'll need to be well prepared to go in there, perhaps there's some way I could open up this crack and get the drop on them!\"", "cyan");
                    Game.Dialogue("\"Of course, even with the element of surprise I'll need to be well armed and ready!\"", "cyan");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Barrackschoice();
                }
                else if (Playerchoice == "3")
                {
                    Console.WriteLine("You decide to return to the hallway.");
                    Game.Bar2Kit();
                }
                else if (Playerchoice == "4")
                {
                    Game.Grumbler();
                    Game.Barrackschoice();
                }
            }
            else
            {
                Game.Barracksstartchoicetwo();
                //Game barrackschoicetwostart
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Barracks stuff above

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Initial hallway leading from the barracks towards the Kitchens and the Guardroom
        //All hallways will be named based on where they came from and where they are going too using the first three letters from each room and a 2 in the middle hence "BarrackstooKitchens" becomes "Bar2Kit"
        //Hopefully that's easy to understand.
        public static void Bar2Kit()
        {
            string? PlayerChoice = "";
            Console.Clear();
            if (Inventory.Contains("LockedSkavenInKitchen"))
            //Checks if the player has been to the kitchen before and barred the door.
            {
                // This activates later once the player has barred the kitchen door and is here for conitnuity.
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You're are now in the hallway between the barracks and the kitchens. The Barracks lies to the south and the Kitchens to the North.");
                Console.WriteLine("The hallway is illuminated by a number of bronze oil lanters which hang in sconces every five five feet down the length of the hall.");
                Console.WriteLine("The hallway is two yards wide and was carved in such a manner as to not need support of any kind. Such is the mastery of trained Dwarven miners.");
                Console.WriteLine("You can see the entrance to the Kitchens, the door is has been barred, though the Skaven seem to have taken no notice..");
                Console.WriteLine("Slurred and shrill chittering can be heard from within the Kitchens.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                //Make this choice dynamic into a seperate object
                Console.WriteLine("What would you like to do " + CharacterName + "?");
                Console.WriteLine("1) Listen to the door of the Kitchens. 2) Proceed down the hall towards the guard room? 3) Grumble. 4) Go to the Barracks.");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Console.WriteLine("You press your ear to the barred door. You can still hear the sounds of Skaven chittering and galivanting. The poor fools.");
                    Console.WriteLine("You step back into the hallway.");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Bar2Kit();
                }
                else if (PlayerChoice == "2")
                {
                    Console.WriteLine("You head to the north to the Guardroom");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Kit2Gua();
                }
                else if (PlayerChoice == "3")
                {
                    Game.Grumbler();
                    Game.Bar2Kit();
                }
                else if (PlayerChoice == "4")
                {
                    Console.WriteLine("You head to the south to the barracks.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Barracks();
                }
            }
            else
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You're are now in the hallway between the barracks and the kitchens. The Barracks lies to the south and the Kitchens to the North.");
                Console.WriteLine("The hallway is illuminated by a number of bronze oil lanters which hang in sconces every five five feet down the length of the hall.");
                Console.WriteLine("The hallway is two yards wide and was carved in such a manner as to not need support of any kind. Such is the mastery of trained Dwarven miners.");
                Console.WriteLine("You can see the entrance to the Kitchens, the door is ajar and the dim light of a fire spills forth into the hall.");
                Console.WriteLine("Slurred and shrill chittering can be heard from within the Kitchens.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                //Make this choice dynamic into a seperate object
                Console.WriteLine("What would you like to do " + CharacterName + "?");
                Console.WriteLine("1) Carefully look into the kitchens? 2) Proceed down the hall towards the guard room? 3) Grumble. 4) Go to the Barracks.");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Game.Kitchens();
                }
                else if (PlayerChoice == "2")
                {
                    Console.WriteLine("You head to the north to the Guardroom");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Guardroom();
                }
                else if (PlayerChoice == "3")
                {
                    Game.Grumbler();
                    Game.Bar2Kit();
                }
                else if (PlayerChoice == "4")
                {
                    Console.WriteLine("You head to the south to the barracks.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Barracks();
                }
            }



        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //End of hallway Bar2Kit

        //=========================================================================================================================================================================
        //Start of Kitchen room and choice tree.
        public static void Kitchens()
        {
            string? PlayerChoice = "";
            if (Inventory.Contains("Kitchensvisit"))
            {
                //Default Kitchens after first look
                Console.WriteLine("You carefully look through the door again and see the Skaven are still drunkenly galivanting within.");
                Console.WriteLine("What would you like to do " + CharacterName + "?");
                Console.WriteLine("1) Return to the hallway? 2) Grumble. 3) Charge into the room and hack them to pieces!");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Console.WriteLine("You leave the Rat bastards to their merriment, they'll get theirs soon enough.");
                    Game.Bar2Kit();
                }
                else if (PlayerChoice == "2")
                {
                    Game.Grumbler();
                    Game.Kitchens();
                }
                else if (PlayerChoice == "3")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You decide it's high time to take matters into your own hands " + CharacterName + ". You kick in the door and scream out a battle cry!");
                    Game.Dialogue("\"Khazukan Kazakit-ha! My axe falls upon you!\"", "cyan");
                    Console.WriteLine("The Skaven stop their carousing and in a panic rush for their weapons! Soon you are joined in battle!");
                    Console.WriteLine("You hack and slash with all your might, hewing limb from flesh and crushign bone! But there are simply too many of them!");
                    Console.WriteLine("In a matter of moments you are overwhelmed. A flurry of desperate stabs and cuts brings you low.");
                    Console.WriteLine("Though many of the Skaven lay slaughtered around you, with your leg already being injured you will quickly succumb to the wounds you have just now sustained.");
                    Console.WriteLine("You slip to the floor and with your dying breath curse the hordes of hell that had come to your mine.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You have died. Press enter to continue.");
                    Console.ReadKey();
                    Console.Clear();

                    //Death screen that boots back to Title/re-runs the game
                    Program.Main();
                }

            }
            else if (Inventory.Contains("Kitchensvisit") && Inventory.Contains("Metalbar"))
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You carefully look through the door again and see the Skaven are still drunkenly galivanting within.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("What would you like to do " + CharacterName + "?");
                Console.WriteLine("1) Return to the hallway? 2) Grumble. 3) Charge into the room and hack them to pieces! 4) Use your Metal Bar to lock them in.");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You leave the Rat bastards to their merriment, they'll get theirs soon enough.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Game.Bar2Kit();
                }
                else if (PlayerChoice == "2")
                {
                    Game.Grumbler();
                    Game.Kitchens();
                }
                else if (PlayerChoice == "3")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You decide it's high time to take matters into your own hands " + CharacterName + ". You kick in the door and scream out a battle cry!");
                    Game.Dialogue("\"Khazukan Kazakit-ha! My axe falls upon you!\"", "cyan");
                    Console.WriteLine("The Skaven stop their carousing and in a panic rush for their weapons! Soon you are joined in battle!");
                    Console.WriteLine("You hack and slash with all your might, hewing limb from flesh and crushign bone! But there are simply too many of them!");
                    Console.WriteLine("In a matter of moments you are overwhelmed. A flurry of desperate stabs and cuts brings you low.");
                    Console.WriteLine("Though many of the Skaven lay slaughtered around you, with your leg already being injured you will quickly succumb to the wounds you have just now sustained.");
                    Console.WriteLine("You slip to the floor and with your dying breath curse the hordes of hell that had come to your mine.");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You have died. Press enter to continue.");
                    Console.ReadKey();
                    Console.Clear();

                    //Death screen that boots back to Title/re-runs the game
                    Program.Main();
                }
                else if (PlayerChoice == "4")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You quietly close the kitchen door and then lock it with the long piece of metal bar you found. It would take an Ogre to break the door down now!");
                    Inventory.Remove("Metal Bar");
                    Inventory.Add("LockedSkavenInKitchen");
                    Game.Dialogue("\"Ah hah! Now the rascals can't escape!\"", "cyan");
                    Console.WriteLine("You return to the hallway. Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Bar2Kit();
                }
            }
            else if (Inventory.Contains("Kitchensvisit")&& Inventory.Contains("LockedSkavenInKitchen")&&Inventory.Contains("BurnedSkavenAlive"))
            {
                //Sequence for exploring the remains of the burned out Kitchens.
            }


            else
            {
                Inventory.Add("Kitchensvisit");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You position yourself on the left side of the door and look through the open crack. Within the kitchen you can see a dozen skaven running amok!");
                Console.WriteLine("The Skaven have smashed open a number of barrels of ale including one of bugmans finest! (A grudge shall be written on this matter later). They are all clearly drunk.");
                Console.WriteLine("The Skaven parade about the place, eating and squabbling in their impaired state.");
                Console.WriteLine("There are far too many of them for you to fight, even in their current state, you'll have to think of something.");
                Console.WriteLine("You notice that the hearth is burning quite intensely and that many of the barrels are positioned near the base of it. Dwarf ale has quite a high proof...");
                Console.WriteLine("You return to the hallway for now.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Bar2Kit();

            }


        }
        //================================================================================================================================================================================================
        //End of the Kitchens scenes.

        //==============================================================================================================================================================================================
        //Start of the Guardroom area and choice trees.
        public static void Kit2Gua()
        {
            //Southern entrance into the guardroom.
            string? PlayerChoice = "";
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You head North continuing along the hall towards the Guardroom. As you approach the end of the hallway, you see the splintered wooden door that marks the southern passage.");
            Console.WriteLine("The door was shattered by a great force, likely a Rat Ogre.");
            Game.Dialogue("\"Need to watch out for the big bastard, he'll be trouble to deal with.\"", "cyan");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("What would you like to do " + CharacterName + "?");
            Console.WriteLine("1) Enter into the Guardroom? 2)Head back towards the Kitchens? 3)Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You Enter the Guardroom");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Guardroom();
            }
            else if (PlayerChoice == "2")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You head back down the ahllway towards the kitchens.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Bar2Kit();
            }
            else if (PlayerChoice == "3")
            {
                Game.Grumbler();
                Console.ReadKey();
                Console.Clear();
                Game.Kit2Gua();
            }
        }
        public static void Gua2Kit()
        {
            // Heading south from the guardroom to the kitchens
            string? PlayerChoice = "";
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You head south exiting the guardroom and heading towards the Kitchens. As you pass into the hallway, you see the splintered wooden door that marks the southern passage.");
            Console.WriteLine("The door was shattered by a great force, likely a Rat Ogre.");
            Game.Dialogue("\"Need to watch out for the big bastard, he'll be trouble to deal with.\"", "cyan");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("What would you like to do " + CharacterName + "?");
            Console.WriteLine("1) Head North into the Guardroom? 2)Head South towards the Kitchens? 3)Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You Enter the Guardroom");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Guardroom();
            }
            else if (PlayerChoice == "2")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You head back down the hallway towards the kitchens.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Bar2Kit();
            }
            else if (PlayerChoice == "3")
            {
                Game.Grumbler();
                Console.ReadKey();
                Console.Clear();
                Game.Kit2Gua();
            }
        }
        public static void Guardroom()
        {
            //Guard room location
            // Where the Rat Ogre chase scene happens, but that will be handled in a seperate method.
            // Weakened post, crossbow, key to the office: Crossbow will be loaded and behind the body of a dwarf, key will be under a table.

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You enter into the Guardroom.A redoubt of modest size, perhaps 10 yards wide and 20 yards long.");
            Console.WriteLine("In better times this room served as the holds second line of defence. Guards would gather here to repel any invader that made it through the front gate.");
            Game.Dialogue("\"Not as effective when the enemy comes from below. Bah, told em we needed that second guard room built by the mines!\"", "cyan");
            Console.WriteLine("You grumble bitterly that no one ever listens to you.");
            Console.WriteLine("There are signs that a great battle took place here. A number of Rat-men corpses lay strewn about, in various states of decay and dismemberment.");
            Console.WriteLine("The room is filled with broken weapons, shields and furniture, with a number of tables and weapon racks having been displaced by the melee");
            Console.WriteLine("The corpse of another Dwarf leans solemnly against the Northern wall, in the corner near the rooms western exit.");
            Game.Dialogue("\"Ah, so they got you too did they Durtrek? Ya, poor bastard.\"", "cyan");
            Console.WriteLine("There are four wooden pillars in the room, one at each corner. Normally this wouldn't be needed but the ceiling above is mostly weak stone and gravel, calling for extra support.");
            Console.WriteLine("It seems like one of the pillars could use some repairs.");
            Console.WriteLine("The Guardroom has three exits: One to the west that leads to the entry, one to the South which goes to the kitchens, and one that heads east to the Workshop.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("What would you like to do " + CharacterName + "?");
            Game.Guardroomchoice();

        }
        public static void Guardroomchoice()
        {
            //leave to the West,South or East & investigate the pillars & investigate the body (find crossbow with one bolt) & look around the room- leads to finding the key & Grumble
            //Make a seperate choice tree for body (cleaner)
            string? PlayerChoice = "";
            Console.WriteLine("1) Leave the guardroom? 2)Pay your respects to Durtrek? 3)Examine the weakened pillar? 4)Take a closer look at the room? 5)Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                Console.WriteLine("Which direction would you like to go?");
                Console.WriteLine("1)South towards the kitchens? 2)West towards the Trade depot and Office? 3)East towards the Workshop?");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    //South
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You exit the room to the south, heading towards the kitchens.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Gua2Kit();

                }
                else if (PlayerChoice == "2")
                {
                    //West- office and Trade depot hallway
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You exit the room to the West, heading towards the Office and the Trade Depot.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Gua2OTD();
                }
                else if (PlayerChoice == "3")
                {
                    //East
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You exit the room to the East, heading towards the Workshop.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Gua2wor();
                }

            }
            else if (PlayerChoice == "2")
            {
                Console.WriteLine("You walk to the North-West corner of the room to pay your respects to your friend Durtrek.");
                Game.Durtreksbody();
            }
            else if (PlayerChoice == "3")
            {
                //weak pillar
                if (Inventory.Contains("Sledgehammer"))
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You examine the weakened pillar once more.");
                    Console.WriteLine("You take a look at the weakened pillar in the top North-Eastern corner of the room.");
                    Console.WriteLine("The pillar is a floor to celiing length of hardwood. It's about as thick around as you are and carved with ornate spirals.");
                    Console.WriteLine("It looks like the pillar has sustained some damage, there's a large dent in the center of it and the floor around it's base is covered in splitners.");
                    Console.WriteLine("Long cracks run up and down the length of the pillar, in truth, it seems to be barely supporting the celiling.");
                    Game.Dialogue("\"Still holding strong I see! Though I bet one solid blow from this Sledgehammer I grabbed would bring the whole thing crashing down!\"", "cyan");
                    Console.WriteLine("Of course, bringing the celing down on your head would likely kill you, and definitley kill anything else!");
                    Console.WriteLine("There's nothing more for you to do here.");
                    Console.WriteLine("You decide to return to the room.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Game.Guardroomchoice();


                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You take a look at the weakened pillar in the top North-Eastern corner of the room.");
                    Console.WriteLine("The pillar is a floor to celiing length of hardwood. It's about as thick around as you are and carved with ornate spirals.");
                    Console.WriteLine("It looks like the pillar has sustained some damage, there's a large dent in the center of it and the floor around it's base is covered in splitners.");
                    Console.WriteLine("Long cracks run up and down the length of the pillar, in truth, it seems to be barely supporting the celiling.");
                    Game.Dialogue("\"A testament to Dwarven construction! She'll hold for another century yet I reckon...er...as long as no one strikes her again!\"", "cyan");
                    Console.WriteLine("You take a look at the celiing around the pillar and realize that if this pillar were to fail, half the room would likely cave in around it!");
                    Console.WriteLine("You turn your attentions elsewhere");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Game.Guardroomchoice();

                }
            }
            else if (PlayerChoice == "4")
            {
                //find key
                if (Inventory.Contains("OfficeKey"))
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You search the room but don't find anything of note.");
                    Console.WriteLine("You turn your attentons elsewhere");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Game.Guardroomchoice();

                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You poke around the wreckage in the room, picking it over for anthing useful.");
                    Console.WriteLine("You check the bodies of the Skaven first finding nothing but a foul smell and terribly maintained armor and weapons.");
                    Console.WriteLine("After searching a little while longer, overturning ruined furniture, and drinking down the remains of any half-empty cup of ale!");
                    Game.Dialogue("\"A shame to waste good Bugmans you know!\"", "cyan");
                    Console.WriteLine("You spot a brassy gleam from beneath a table and find a small key!");
                    Inventory.Add("OfficeKey");
                    Console.WriteLine("You take the key with you and turn your attentions elsewhere.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Game.Guardroomchoice();
                }
            }
            else if (PlayerChoice == "5")
            {
                Game.Grumbler();
                Game.Guardroomchoice();
            }

        }
        public static void Durtreksbody()
        {
            string? PlayerChoice = "";
            //where you get the crossbow, unless you already have it.
            Console.Clear();
            if (Inventory.Contains("Crossbow"))
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Durtreks bearded form lies still on the cold stone. His mail is pierced in several places, it clearly took many blows to fell him.");
                Game.Dialogue("\"For each death, another grudge will be written. I swear you shall be avenged, or I shall shave my head and take the oath!\"", "cyan");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1)Pay your respects and head back to the room? 2)Grumble?");
                PlayerChoice = Console.ReadLine();
                if (PlayerChoice == "1")
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("You say a quick prayer to Valaya too guide Durtreks spirit to rest.");
                    Console.WriteLine("Press Enter to Continue");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.Clear();
                    Game.Guardroom();
                }
                else if (PlayerChoice == "2")
                {
                    Game.Grumbler();
                    Game.Durtreksbody();
                }

            }
            else
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Durtreks bearded form lies still on the cold stone. His mail is pierced in several places, it clearly took many blows to fell him.");
                Game.Dialogue("\"For each death, another grudge will be written. I swear you shall be avenged, or I shall shave my head and take the oath!\"", "cyan");
                Console.WriteLine("His body seems to be resting on something! You aren't one to disturb the rest of a fallen warrior but you decide to take a look.");
                Console.WriteLine("You shift Durtreks body to one side and find that he was resting on a crossbow!");
                Game.Dialogue("\"This could come in handy!\"", "cyan");
                Inventory.Add("Crossbow");
                Console.WriteLine("Sadly there is only one bolt, you'll have to use it wisely");
                Console.WriteLine("You return to the room.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Guardroom();
            }
        }
        //===============================================================================================================================================================================================
        //End of the Guardroom.
        //===============================================================================================================================================================================================
        //Below is the hallway/rooms/choice trees for the Trade Depot and office

        public static void Gua2OTD()
        {
            //Heading from the guardroom towards either of these rooms.
        }
        //End of Trade/Office
        //================================================================================================================================================================================================
        //Choice trees begin for the Workshop hallway and Workshop.
        public static void Gua2wor()
        {
            //Hallway heading east towards workshop, first time player enters they should see the guards at the end of the hall. This won't stop them progressing further east or north, only south.
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You leave behind the Guardroom and head Eastwards towards the worshop");
            if (Inventory.Contains("G2WVisit"))
            {
                //Chocie that activates after the player has made their way through this hallway for the first time, but before they've taken care of the Skaven guards/Stormvermin
                Console.WriteLine("As you reach the end of the hallway a junction comes into sight.");
                Console.WriteLine("There is an Eastern passage which will take you to the workshop, a Northern passage leading to the temple and powder room, and a Southern passage.");
                Console.WriteLine("The Southern passage is still guarded by the two Stormvermin.");
                Game.Dialogue("\"Best avoid going that way until I'm good and ready for a fight!\"", "cyan");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.Gua2Worchoice();

            }
            else if (Inventory.Contains("DeadStormvermin"))
            {
                //Choice activates after the player has managed to kill the Stormvemrin using the crossbow.
                Console.WriteLine("As you reach the end of the hallway a junction comes into sight.");
                Console.WriteLine("There is an Eastern passage which will take you to the workshop, a Northern passage leading to the temple and powder room, and a Southern passage.");
                Console.WriteLine("You've dealt with the Stormvermin in the southern passage, now you can head further south towards the Forge and the Mines.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.Gua2Worchoice();
            }

            else
            {
                //Default choice that activated the first time the player enters into this part of the hall. 
                Console.WriteLine("As you reach the end of the hallway a junction comes into sight.");
                Console.WriteLine("There is an Eastern passage which will take you to the workshop, a Northern passage leading to the temple and powder room, and a Southern passage.");
                Console.WriteLine("As you peer down the Southern passage, you realize that two Skaven are standing guard! Perhaps only 50 ft down the hall!");
                Console.WriteLine("The lazy wazzoks haven't noticed you, so poor is there work ethic and watchman-ship!");
                Console.WriteLine("While theres only two of them, they are well armed with long spears and broad shields, these aren't typical Skaven stock!");
                Console.WriteLine("You'll need to come up with a clever way to beat them should you wish to head south!");
                Console.WriteLine("Though you suspect you'll have no trouble sneaking by them if you head another way...");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.Gua2Worchoice();


            }


        }
        public static void Gua2Worchoice()
        {
            //choice tree for the Guard 2 Workshop hallway, inlcuding logic to check for various other steps and stages in the path.

            string? PlayerChoice = "";
            Console.WriteLine("What would you like to do " + CharacterName + "?");
            Console.WriteLine("Would you like to? 1) Go south? 2) Go North? 3) Go East to the Workshop? 4)Go back the way you came? 5)Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You make your way south, heading towards the Storage room.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Wor2Sto();

            }
            else if (PlayerChoice == "2")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You make your way North, heading towards the Temple and the Powder room.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Wor2Tem();
            }
            else if (PlayerChoice == "3")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You make your way East, heading into the Workshop.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Workshop();
            }
            else if (PlayerChoice == "4")
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You make your way back west, heading back into the Guardroom.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Game.Guardroom();
            }
            else if (PlayerChoice == "5")
            {
                Game.Grumbler();
                Game.Gua2Worchoice();
            }
        }
        public static void Workshop()
        {
            //Sledgehammer is located in this room! Room is large enough to fit the dwarves various tools and work-benches, most of which won't come in handy now.
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Leaving the hallway behind, you walk through the wide entryway and into the Workshop.");
            Console.WriteLine("Even before the Skaven arrived this room was a mess! The walls are still unfinished bare rock, adorned with hooks and shelves to store the Dwarves various tools.");
            Console.WriteLine("The room is 15 yards long and 10 yards wide, though you wouldn't think it to be that large when stood in the center of it!");
            Console.WriteLine("The room is packed to the brim with benches and tools, a bench for masonry, carpentry, tool smithing, blacksmithing, jewelery, metalwork, and so on and so forth.");
            Game.Dialogue("\"Anything and everything a growing hold could need!\"", "cyan");
            Console.WriteLine("You speak aloud to the clutter.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Game.WorkshopChoice();
        }
        public static void WorkshopChoice()
        {
            string? PlayerChoice = "";
            Console.WriteLine("What would you like to do " + CharacterName + "?");
            Console.WriteLine("1) Examine the workbenches? 2) Take a look at the wall racks? 3) Leave the Workshop? 4) Grumble?");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {
                //Find nothing
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("You decide to take a closer look at a few of the workbenches.");
                Console.WriteLine("");
                ww("");
                ww("");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Game.WorkshopChoice();
            }
            else if (PlayerChoice == "2")
            {
                //Sledge+ Check if the player already has the sledge
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            }
            else if (PlayerChoice == "3")
            {
                //Go back the hallway
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            }
            else if (PlayerChoice == "4")
            {
                Game.Grumbler();
                Game.WorkshopChoice();
            }
        }
        //============================================================================================================================================================================================
        //End of Workshop+Hallway choice trees
        //============================================================================================================================================================================================
        public static void Wor2Sto()
        {

        }
        public static void Wor2Tem()
        {

        }


        public class Character
        {
            //Character information- Eventually for things like hitpoints
        }
       

        
        public class Item
        {
            //Items used to solve puzzles
           
        }
        public class Program
        {
            public static void Main()
            {
                Game.Title();
                Game.Startgame();
                Console.ReadKey();
                Game.Intro();

            }
        }
    }  
}