namespace EscapeRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTitle();
            TryKeypad();
        }

        private static void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine(@"
             ___                         ___
            | __|___ __ __ _ _ __  ___  | _ \___  ___ _ __
            | _|(_-</ _/ _` | '_ \/ -_) |   / _ \/ _ \ '  \
            |___/__/\__\__,_| .__/\___| |_|_\___/\___/_|_|_|
                            |_|
            ================================================
            ");
        }

        private static void ShowIntro()
        {
            Console.WriteLine("Solve the puzzles before time runs out!");
            Console.WriteLine("Press enter to start your adventure...");
            Console.ReadLine();
        }

        private static void ShowColoredText(string text, ConsoleColor color, bool appendLine)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            if (appendLine)
            {
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private static void ShowStatus(int timeLeft, bool keypadSolved, bool riddleSolved)
        {
            ShowColoredText($"Time left: {timeLeft} minutes", ConsoleColor.Blue, true);
            ShowColoredText($"Keypad: {(keypadSolved ? "solved" : "unsolved")}", ConsoleColor.Blue, true);
            ShowColoredText($"Riddle: {(riddleSolved ? "solved" : "unsolved")}", ConsoleColor.Blue, true);
            Console.WriteLine();
        }      

        private static void ShowMenu()
        {
            ShowColoredText("Choose an action:", ConsoleColor.White, true);
            ShowColoredText("  1) Try keypad", ConsoleColor.White, true);
            ShowColoredText("  2) Solve riddle", ConsoleColor.White, true);
            ShowColoredText("  3) Open final door", ConsoleColor.White, true);
            ShowColoredText("  9) Give up", ConsoleColor.White, true);
            ShowColoredText("Your choice: ", ConsoleColor.White, false);
        }

        private static int ReadAction()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return -1;
        }

        private static int ApplyPenalty(int timeLeft, int penalty)
        {
            int newTime = timeLeft - penalty;
            if (newTime < 0)
            {
                newTime = 0;
            }
            ShowColoredText($"Time penalty: -{penalty} minute(s).", ConsoleColor.DarkYellow, true);
            return newTime;
        }

        private static bool TryKeypad()
        {
            ShowColoredText("Enter 3-digit keypad code: ", ConsoleColor.Magenta);
            string input = Console.ReadLine();

            if (!int.TryParse(Console.ReadLine(), out int output)
            {
                ShowColoredText($"Invalid Code (not a number)", ConsoleColor.DarkRed, false);
            }
            else if()
            {

            }
        }
    }
}
