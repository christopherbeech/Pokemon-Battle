using System;

namespace PokemonBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            StartApp();

            Console.ReadLine();
        }

        static void StartApp()
        {
            bool quit = true;

            do
            {
                Console.WriteLine("Hello Trainer! Choose a Pokemon Partner.\n");
                Console.WriteLine("(1) Charamander, Type: Fire, Attack: Flamethrower\n(2) Squirtle, Type: Water, Attack: Water Gun\n(3) Bulbasaur, Type: Grass, Attack: Vine Wipe\n(4) Pikachu, Type: Electric, Attack: Thunderbolt\n");
                string pokemon = Console.ReadLine().ToLower();

                switch (pokemon)
                {
                    case "charamander":
                    case "1":
                        Console.WriteLine("Are you sure that you want Charamander? (yes or no)\n");
                        string affirm1 = Console.ReadLine();

                        if (affirm1 == "yes")
                        {
                            Console.WriteLine("Awesome choice! Charamander is yours.\n");
                            Battle("Charamander", "Flamethrower");
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case "squirtle":
                    case "2":
                        Console.WriteLine("Are you sure that you want Squirtle? (yes or no)\n");
                        string affirm2 = Console.ReadLine();

                        if (affirm2 == "yes")
                        {
                            Console.WriteLine("Awesome choice! Squirtle is yours.\n");
                            Battle("Squirtle", "Water Gun");
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case "bulbasaur":
                    case "3":
                        Console.WriteLine("Are you sure that you want Bulbasaur? (yes or no)\n");
                        string affirm3 = Console.ReadLine();

                        if (affirm3 == "yes")
                        {
                            Console.WriteLine("Awesome choice! Bulbasaur is yours.\n");
                            Battle("Bulbasaur", "Vine Whip");

                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case "pikachu":
                    case "4":
                        Console.WriteLine("Are you sure that you want Pikachu? (yes or no)\n");
                        string affirm4 = Console.ReadLine();

                        if (affirm4 == "yes")
                        {
                            Console.WriteLine("Awesome choice! Pikachu is yours.\n");
                            Battle("Pikachu", "Thunderbolt");

                        }
                        else
                        {
                            continue;
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid choice\n");
                        break;
                }

                Console.WriteLine("Do you wish to continue? (yes or no)\n");
                string leaveApp = Console.ReadLine().ToLower();

                if (leaveApp == "no")
                {
                    Console.WriteLine("See you later!");
                    quit = false;
                }

            } while (quit);
        }

        static void Battle(string name, string attack)
        {
            int myPokemon = 25;
            int wildPokemon = 30;

            Random dice = new Random();

            Console.WriteLine("A wild Pidgeotto appeared. LET'S BATTLE!!!\n");
            Console.WriteLine($"<----{name} HP:{myPokemon} VS. Pidgeotto HP:{wildPokemon}---->\n");

            do
            {
                int roll = dice.Next(1, 12);
                wildPokemon -= roll;
                Console.WriteLine($"Pidgeotto's HP:{wildPokemon}");
                Console.WriteLine($"YOUR TURN: {name} use {attack}! The wild Pokemon was damaged and lost {roll} health and now has {wildPokemon} health.\n");

                if (wildPokemon <= 0) continue;

                roll = dice.Next(1, 11);
                myPokemon -= roll;
                Console.WriteLine($"{name}'s HP:{myPokemon}");
                Console.WriteLine($"The wild Pidgeotto used Gust! {name} was damaged and lost {roll} health and now has {myPokemon} health.\n");

            } while (myPokemon > 0 && wildPokemon > 0);

            Console.WriteLine(myPokemon > wildPokemon ? $"You and {name} WON the battle!!! :)\n" : $"....You and {name} were DEFEATED by the wild Pidgeotto.... :(\n");
        }
    }
}
