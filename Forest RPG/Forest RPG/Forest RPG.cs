using System;

class ForestOfFates
{
    static void Main()
    {
        // Introduction
        Console.WriteLine("Welcome to the Forest of Fates.");
        Console.WriteLine("Legends speak of a forgotten power within these woods. Will your senses guide you in the right direction? Or will you suffer a fate worse than death.");
        Console.WriteLine("Your journey begins now. Choose LEFT or RIGHT at each fork.");
        Console.WriteLine();

        // Level 1
        Console.WriteLine("You enter the forest and reach a moss-covered stone archway. You move through it to an open feild.  To your left you see what appears to be a glowing tree in the woods.");
        Console.WriteLine("To the right there is a dark trail, but you cannot see much else.");
        Console.WriteLine("Do you go LEFT toward the glowing trees or RIGHT into the shadowy trail?");
        Console.Write("Choice: ");
        string choice1 = Console.ReadLine()?.Trim().ToLower();
        bool wentLeft1 = choice1 == "left";

        // Level 2
        if (wentLeft1)
        {
            Console.WriteLine("As you enter the forest you're drawn towards the centre. There a single tree stands out. The glowing tree hums with some unknown energy.");
            Console.WriteLine("As you approach the tree you begin to hear whispers.  They beckon you closer to the tree.");
            Console.WriteLine("Do you follow the whispers (LEFT) or ignore them and move on (RIGHT)?");
            Console.Write("Choice: ");
            string choice2 = Console.ReadLine()?.Trim().ToLower();
            bool wentLeft2 = choice2 == "left";

            // Level 3
            if (wentLeft2)
            {
                Console.WriteLine("The whispers guide you to the glowing tree, the forest closing in behind you. You can hear the tree speaking to you. Not out loud but in your mind. It tells you of a shimmering lake surrounded by ancient runes, glowing much like the tree.");
                Console.WriteLine("Drink of the lake, feel the forest");
                Console.WriteLine("As there was no other way to go your head foward and eventally find this lake. There is a clear path around it.");
                Console.WriteLine("Do you drink from the lake (LEFT) or walk around it cautiously (RIGHT)?");
                Console.Write("Choice: ");
                string choice3 = Console.ReadLine()?.Trim().ToLower();
                bool wentLeft3 = choice3 == "left";

                // Level 4
                if (wentLeft3)
                {
                    Console.WriteLine("You walk up to the lake, and without a second guess drink the water. The water burns your throat, and your begins to vision fades out.");
                    Console.WriteLine("You feel as though power floods your veins.");
                    Console.WriteLine("Do you embrace the power (LEFT) or resist its pull (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("You give in. A surge elemental forces fills your body. You're able to leave the forest and begin a journey to carve your name into legend.");
                        Console.WriteLine("Ending A: Power");
                    }
                    else
                    {
                        Console.WriteLine("The power fades, however there are lasting visions of the forest's ancient past. You become filled with all it's knowledge, and are changed forever for the better.");
                        Console.WriteLine("Ending B: Wisdom");
                    }
                }
                else
                {
                    Console.WriteLine("Behind the lake lies a similarly rune-marked pedestal. On this pedestal, you uncover a scroll sealed in bone.");
                    Console.WriteLine("Do you read the scroll (LEFT) or leave it untouched (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("The scroll reveals forbidden knowledge of the dungeon below.");
                        Console.WriteLine("Ending B: Wisdom");
                    }
                    else
                    {
                        Console.WriteLine("A shadow rises from the lake and drags you into the depths.");
                        Console.WriteLine("Ending C: Doom");
                    }
                }
            }
            else
            {
                Console.WriteLine("You stumble into a grove of sleeping beasts—horned, scaled, and ancient.");
                Console.WriteLine("Do you sneak past (LEFT) or wake them with a shout (RIGHT)?");
                Console.Write("Choice: ");
                string choice3 = Console.ReadLine()?.Trim().ToLower();
                bool wentLeft3 = choice3 == "left";

                // Level 4
                if (wentLeft3)
                {
                    Console.WriteLine("You tiptoe past and discover a crumbling shrine guarded by a cloaked hermit.");
                    Console.WriteLine("Do you speak with him (LEFT) or continue deeper alone (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("The hermit shares ancient wisdom and marks you as a forest guardian.");
                        Console.WriteLine("Ending B: Wisdom");
                    }
                    else
                    {
                        Console.WriteLine("You wander into a maze of thorns and are never seen again.");
                        Console.WriteLine("Ending C: Doom");
                    }
                }
                else
                {
                    Console.WriteLine("The beasts awaken and roar. You flee blindly into the underbrush.");
                    Console.WriteLine("Do you climb a gnarled tree (LEFT) or sprint toward a stone ruin (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("You hide among the branches and spot a trapdoor beneath the roots.");
                        Console.WriteLine("You descend into a forgotten chamber filled with relics.");
                        Console.WriteLine("Do you claim the glowing artifact (LEFT) or study its inscriptions (RIGHT)?");
                        Console.Write("Choice: ");
                        string artifactChoice = Console.ReadLine()?.Trim().ToLower();
                        bool tookArtifact = artifactChoice == "left";

                        if (tookArtifact)
                        {
                            Console.WriteLine("The artifact pulses with raw energy. You wield its power to reshape the forest.");
                            Console.WriteLine("Ending A: Power");
                        }
                        else
                        {
                            Console.WriteLine("The inscriptions reveal truths about the forest's origin and your destiny.");
                            Console.WriteLine("Ending B: Wisdom");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You fall into a pit of bones and silence swallows you.");
                        Console.WriteLine("Ending C: Doom");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The shadowy trail leads to a ruined tower wrapped in thorny vines.");
            Console.WriteLine("Do you enter the tower (LEFT) or explore the woods nearby (RIGHT)?");
            Console.Write("Choice: ");
            string choice2 = Console.ReadLine()?.Trim().ToLower();
            bool wentLeft2 = choice2 == "left";

            // Level 3
            if (wentLeft2)
            {
                Console.WriteLine("Inside the tower, you find a glowing orb floating above a cracked pedestal.");
                Console.WriteLine("Do you touch the orb (LEFT) or study it from afar (RIGHT)?");
                Console.Write("Choice: ");
                string choice3 = Console.ReadLine()?.Trim().ToLower();
                bool wentLeft3 = choice3 == "left";

                // Level 4
                if (wentLeft3)
                {
                    Console.WriteLine("The orb surges with power and binds itself to your soul.");
                    Console.WriteLine("Do you use it to reshape the forest (LEFT) or protect it (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("You become ruler of the forest, feared and revered.");
                        Console.WriteLine("Ending A: Power");
                    }
                    else
                    {
                        Console.WriteLine("You become its silent guardian, watching over its secrets.");
                        Console.WriteLine("Ending B: Wisdom");
                    }
                }
                else
                {
                    Console.WriteLine("A trap activates and the tower collapses into rubble.");
                    Console.WriteLine("Ending C: Doom");
                }
            }
            else
            {
                Console.WriteLine("You find a circle of mushrooms glowing faintly in the moonlight.");
                Console.WriteLine("Do you step inside (LEFT) or walk around cautiously (RIGHT)?");
                Console.Write("Choice: ");
                string choice3 = Console.ReadLine()?.Trim().ToLower();
                bool wentLeft3 = choice3 == "left";

                // Level 4
                if (wentLeft3)
                {
                    Console.WriteLine("You are transported to a realm of fairies and forgotten magic.");
                    Console.WriteLine("Do you accept their gift (LEFT) or decline politely (RIGHT)?");
                    Console.Write("Choice: ");
                    string choice4 = Console.ReadLine()?.Trim().ToLower();
                    bool wentLeft4 = choice4 == "left";

                    if (wentLeft4)
                    {
                        Console.WriteLine("You gain magical powers and become a myth among mortals.");
                        Console.WriteLine("Ending A: Power");
                    }
                    else
                    {
                        Console.WriteLine("You return wiser and more attuned to nature’s balance.");
                        Console.WriteLine("Ending B: Wisdom");
                    }
                }
                else
                {
                    Console.WriteLine("You get lost in the woods and vanish without a trace.");
                    Console.WriteLine("Ending C: Doom");
                }
            }
        }

        // Outro
        Console.WriteLine("Thanks for playing Forest of Fates.");
    }
}