namespace dicedual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roundCount = 1;
            int playerWinCount = 0;
            int npcWinCount = 0;

            PrintStart();
            do
            {
                Console.Clear();
                PrintRound(roundCount, playerWinCount, npcWinCount);
                int playerSum;
                int npcSum;

                Console.WriteLine();
                playerSum = RollThreeDice("Player");
                npcSum = RollThreeDice("Computer");

                if (playerSum > npcSum)
                {
                    Console.WriteLine("Player wins this round");
                    playerWinCount++;

                }
                else if (npcSum > playerSum)
                {
                    Console.WriteLine("Computer wins this round");
                    npcWinCount++;

                }
                else
                {
                    Console.WriteLine("Its a TIE. No points awarded");

                }

                Console.WriteLine();
                Console.WriteLine("Press enter for next round...");
                roundCount++;
                Console.ReadKey();

            } while (playerWinCount < 3 && npcWinCount < 3);

            Console.Clear();
            Console.WriteLine("=== GAME OVER ===");
            Console.WriteLine();

            if (playerWinCount > npcWinCount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WON THE DICE DUAL!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("THE COMPUTER WON THE DICE DUAL!");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine($"Final score - Player: {playerWinCount}, Computer: {npcWinCount}");
            Console.WriteLine();
            Console.WriteLine("Press Enter To Quit.");
            Console.ReadKey();

        }
        private static void PrintStart()
        {
            Console.WriteLine("=== DUAL DICE ===");
            Console.WriteLine();
            Console.WriteLine("Best out of five wins");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void PrintRound(int round, int playerWins, int computerWins)
        {
            Console.WriteLine($"--- ROUND: {round}");

            if (playerWins > computerWins)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Player wins: {playerWins}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Computer wins: {computerWins}");
                Console.ResetColor();

            }
            else if (playerWins < computerWins)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Player wins: {playerWins}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Computer wins: {computerWins}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Player wins: {playerWins} | Computer wins: {computerWins}");
            }




        }

        private static int RollDice()
        {
            Random rng = new Random();
            return rng.Next(1, 7);

        }

        private static int RollThreeDice(string name)
        {
            Console.WriteLine($"{name} ROLLED");
            int roll1 = RollDice();
            int roll2 = RollDice();
            int roll3 = RollDice();

            Console.WriteLine($"Dice 1: {roll1}");
            Console.WriteLine($"Dice 2: {roll2}");
            Console.WriteLine($"Dice 3: {roll3}");

            int sum = roll1 + roll2 + roll3;

            Console.WriteLine($"TOTAL: {sum}");
            return sum;
        }
    }
}
