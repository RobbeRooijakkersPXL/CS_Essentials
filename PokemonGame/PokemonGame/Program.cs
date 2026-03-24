namespace PokemonGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();

            int yourStarterChoice = 0;
            int yourEnemyPokemon = 0;
            bool defeated = false;
            bool won = false;
            int yourStarterHealth = rng.Next(30, 51);
            string yourStarterType;
            string yourEnemyType;
            bool battleReady = false;

            do
            {
                do {
                    ShowLogo();
                    ShowIntro();
                    TextColor("You entered proffesor Oak's Lab", ConsoleColor.Magenta);

                    yourStarterChoice = ChoosePokemon();
                    yourStarterType = YourPokemonType(yourStarterChoice);

                    yourEnemyPokemon = EnemyPokemon();
                    yourEnemyType = EnemyPokemonType(yourEnemyPokemon);




                    Console.ReadLine();
                } while (!battleReady);
                



                Console.ReadLine();

            } while (!defeated && !won);


        }

        private static void ShowLogo()
        {
            Console.Clear();
            Console.WriteLine("  _____      _                              \r\n |  __ \\    | |                             \r\n | |__) |__ | | _____ _ __ ___   ___  _ __  \r\n |  ___/ _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\ \r\n | |  | (_) |   <  __/ | | | | | (_) | | | |\r\n |_|   \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_|\r\n                                            \r\n                                            ");

        }

        private static void ShowIntro()
        {
            Console.WriteLine("Welcome to the pokemon world!");
        }

        private static void TextColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }

        private static int ChoosePokemon()
        {
            Console.WriteLine("Choose 1 of the following pokemon as ur starter.");
            TextColor("1. Squirtle (Water)", ConsoleColor.Blue);
            TextColor("2. Charmander (Fire) ", ConsoleColor.Red);
            TextColor("3. Bulbasaur (Grass)", ConsoleColor.Green);
            string starterChoice = Console.ReadLine();

            if (!int.TryParse(starterChoice, out int input))
            {
                return -1;
            }
            else
            {
                switch (input)
                {
                    case 1:
                        TextColor("Your choice: Squirtle (Water)", ConsoleColor.Blue);
                        Console.WriteLine();

                        break;

                    case 2:

                        TextColor("Your choice: Charmander (Fire) ", ConsoleColor.Red);
                        Console.WriteLine();

                        break;

                    case 3:
                        TextColor("Your choice: Bulbasaur (Grass)", ConsoleColor.Green);
                        Console.WriteLine();

                        break;

                    default:
                        TextColor("Wrong input, try again", ConsoleColor.DarkRed);
                        Console.WriteLine();
                        break;
                }
            }

                return input;
        }

        private static int EnemyPokemon()
        {
            Console.WriteLine("Choose 1 of the following pokemon as ur enemy.");
            TextColor("1. Chikorita (Grass)", ConsoleColor.Green);
            TextColor("2. Cyndaquil (Fire)", ConsoleColor.Red);
            TextColor("3. Totodile (Water) ", ConsoleColor.Blue);
            string enemyChoice = Console.ReadLine();

            if (!int.TryParse(enemyChoice, out int output))
            {
                return -1;
            }
            else
            {
                {
                    switch (output)
                    {
                        case 1:
                            TextColor("Enemy: Chikorita (Grass)", ConsoleColor.Green);
                            Console.WriteLine();
                            break;

                        case 2:
                            TextColor("Enemy. Cyndaquil (Fire)", ConsoleColor.Red);
                            Console.WriteLine();
                            break;
                        case 3:
                            TextColor("Enemy. Totodile (Water) ", ConsoleColor.Blue);
                            Console.WriteLine();
                            break;
                        default:
                            TextColor("Wrong input, try again", ConsoleColor.DarkRed);
                            Console.WriteLine();
                            break;
                    }

                }

                return output;
            }
        }

        private static string YourPokemonType(int input)
        {
            if (input == 1)
            {
                return "water";
            }else if (input == 2)
            {
                return "fire";
            }
            else
            {
                return "grass";
            }
        }

        private static string EnemyPokemonType(int input)
        {
            if (input == 1)
            {
                return "grass";
            }
            else if (input == 2)
            {
                return "fire";
            }
            else
            {
                return "water";
            }
        }
    }
}
