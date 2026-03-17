namespace EscapeRoom2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartGame();

            
        }
        private static void StartGame()
        {
            int minutesLeft = 15;
            bool isKeypadSolved = false;
            bool isRiddleSolved = false;
            bool escaped = false;
            bool gaveUp = false;


            do
            {
                ShowTitle();
                ShowIntro();
                ShowStatus(minutesLeft, isKeypadSolved, isRiddleSolved);
                ShowMenu();
                int action = ReadAction();

                switch (action)
                {
                    case 1:
                        if(isKeypadSolved == true)
                        {
                            ShowColoredText("The Keypad is already solved!", ConsoleColor.Green, true);
                        }
                        else
                        {
                            isKeypadSolved = TryKeypad();
                            if(isKeypadSolved == false)
                            {
                                minutesLeft = ApplyPenalty(minutesLeft, 2);
                            }
                        }

                        
                        break;

                    case 2:
                        if(isRiddleSolved == true)
                        {
                            ShowColoredText("The Riddle was already solved!", ConsoleColor.Green, true);
                        }
                        else
                        {
                            isRiddleSolved = SolveRiddle();
                            if(isRiddleSolved == false)
                            {
                                minutesLeft = ApplyPenalty(minutesLeft, 2);
                            }
                        }
                        
                        break;

                    case 3:
                        escaped = FinalDoor(isKeypadSolved, isRiddleSolved);
                        if (!escaped)
                        {
                            minutesLeft = ApplyPenalty(minutesLeft, 1);
                        }

                        break;

                    case 9:
                        gaveUp = true;
                        break;

                    default:
                        minutesLeft = ApplyPenalty(minutesLeft, 2);
                        break;

                }

                
                Console.ReadLine();
            } while (!escaped && !gaveUp);
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
            ShowColoredText($"Time penalty: -{penalty} minute(s).", ConsoleColor.DarkYellow, false);
            return newTime;
        }

        private static bool TryKeypad()
        {
            ShowColoredText("Enter 3-digit keypad code: ", ConsoleColor.Magenta, false);
            string input = Console.ReadLine().Trim();

            if (input.Equals("314"))
            {
                ShowColoredText("Keypad Unlocked", ConsoleColor.Green, true);
                return true;

            }
            else if (int.TryParse(input, out _))
            {
                ShowColoredText("Wrong Code!", ConsoleColor.Red, true);
                return false;
            }
            else
            {
                ShowColoredText("Invalid Code!", ConsoleColor.DarkRed, true);
                return false;
            }

            
        }

        private static bool SolveRiddle()
        {
            ShowColoredText("Riddle: Speak friend and enter...", ConsoleColor.Magenta, true);
            ShowColoredText("Type the secret word: ", ConsoleColor.Magenta, true);

            string answer = Console.ReadLine();

            if(answer.Equals("open-sesame", StringComparison.OrdinalIgnoreCase))
            {
                ShowColoredText("The wall slides aside", ConsoleColor.Green, true);
                return true;
            }
            else
            {
                ShowColoredText("The wall remains silend", ConsoleColor.Red, true);
                return false;
            }
        }
        
        private static bool FinalDoor(bool keypadSolved, bool riddleSolved)
        {
            //TODO: Controleer keypadSolved en riddleSolved
            if(!keypadSolved || !riddleSolved)
            {
                ShowColoredText("The final door won’t budge. Solve the other puzzles first.", ConsoleColor.Red, true);
                return false;
            }


            ShowColoredText("Final number (1..5): ", ConsoleColor.Magenta, false);
            string input = Console.ReadLine();

            //TODO: Vul verder aan

            if (input.Equals("3"))
            {
                ShowColoredText("You hear the lock click!", ConsoleColor.Green, true);
                return true;

            }
            else if (!int.TryParse(input, out _))
            {
                ShowColoredText("That is not between 1 and 5.", ConsoleColor.DarkRed, true);
                return false;
            }
            else
            {
                ShowColoredText("A buzzer sounds. Wrong!", ConsoleColor.DarkRed, true);
                return false;
            }
        }
    }
}
