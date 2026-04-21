using PokemonArray.Models;

namespace PokemonArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rng = new Random();
            

            //1.2
            string[] pokemons = new string[6];

            //1.3
            pokemons[0] = "Pikachu";
            pokemons[1] = "Bulbasaur";
            pokemons[2] = "Charmender";
            pokemons[3] = "Squirtle";

            //1.5
            Array.Clear(pokemons, 2, 1);

            //1.6
            PrintPokemonRoster(pokemons);
            Console.WriteLine();

            //1.7
            bool isValid = IsValidPokemonRosterSize(pokemons);
            Console.WriteLine($"Geldige lengte: {(isValid ? "ja" : "nee")}");

            //1.8
            string[] evolutions = new string[6] {"Ivysaur", "Venusaur", "Wartortle", "Blastoise", "Charmeleon", "Charizard" };
            PrintPokemonRoster(evolutions);
            Console.WriteLine();

            //1.9
            Trainer trainer1 = new Trainer();
            trainer1.Name = "Robbe";
            trainer1.Pokemons = new Pokemon[6]
            {
                new Pokemon("Stoutland", GiveRandomLevel(rng), "Normal"),
                new Pokemon("Poliwrath", GiveRandomLevel(rng), "Water"),
                new Pokemon("Boldore", GiveRandomLevel(rng), "Ground"),
                new Pokemon("Golem", GiveRandomLevel(rng), "Ground"),
                new Pokemon("Vanilluxe", GiveRandomLevel(rng), "Ice"),
                new Pokemon("Meloetta Pirouette", GiveRandomLevel(rng), "Psychic")
            };
            Console.WriteLine($"Pokemons van trainer {trainer1.Name}");
            PrintPokemonRoster(trainer1.Pokemons);
            Console.WriteLine();

            Trainer trainer2 = new Trainer();
            trainer2.Name = "Bram";
            trainer2.Pokemons = new Pokemon[6]
            {
                new Pokemon("Pachirisu", GiveRandomLevel(rng), "Electric"),
                new Pokemon("Koraidon", GiveRandomLevel(rng), "Dragon"),
                new Pokemon("Blitzle", GiveRandomLevel(rng), "Electric"),
                new Pokemon("Swinub", GiveRandomLevel(rng), "Ground"),
                new Pokemon("Shieldon", GiveRandomLevel(rng), "Steel"),
                new Pokemon("Bombirdier", GiveRandomLevel(rng), "Dark")
            };
            Console.WriteLine($"Pokemons van trainer {trainer2.Name}");
            PrintPokemonRoster(trainer2.Pokemons);
            Console.WriteLine();

            //1.10
            TradeFirstPokemon(trainer1, trainer2);
            Console.WriteLine($"Pokemons van trainer {trainer1.Name} na de trade:");
            PrintPokemonRoster(trainer1.Pokemons);
            Console.WriteLine();
            Console.WriteLine($"Pokemons van trainer {trainer2.Name} na de trade:");
            PrintPokemonRoster(trainer2.Pokemons);

        }

        private static void PrintPokemonRoster(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {array[i]}");
            }
        }

        private static bool IsValidPokemonRosterSize(string[] array)
        {
            return array.Length == 6;
        }
    
        private static void PrintPokemonRoster(Pokemon[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is not null)
                {
                    Console.WriteLine($"{i + 1}: {array[i].ToString()}");
                }
                


            }
        }

        private static int GiveRandomLevel(Random rng)
        {
            
            return rng.Next(1, 50);
        }

        private static void TradeFirstPokemon(Trainer trainer1, Trainer trainer2)
        {
            Pokemon temp = trainer1.Pokemons[0];
            trainer1.Pokemons[0] = trainer2.Pokemons[0];
            trainer2.Pokemons[0] = temp;
        }
    }
}
