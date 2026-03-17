namespace Raadspelletje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            StartCheck(number.Next(1, 101));


        }



        private static void StartCheck(int number) //int number = random number
        {
            bool isCorrect = false;
            int round = 0;

            do
            {
                round++;
                int input = GiveAnswer();
                isCorrect = CheckAnswer(input, number);
            } while (isCorrect == false);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"U hebt het getal geraden in {round} ronden");
            Console.ResetColor();
            

        }

        private static int GiveAnswer()
        {
            
            int output = 0;
            bool correctInput;
            do
            {
                correctInput = true;
                Console.Write("Geef een getal tussen 1 - 100: ");
                
                if (!int.TryParse(Console.ReadLine(), out output) || output < 1 || output > 100)
                {
                    Console.WriteLine("Ongeldig getal");
                    correctInput = false;
                }
                

            } while (correctInput == false);
            
            return output;

        }
        private static bool CheckAnswer(int input, int numberToGuess)
        {
            if(input == numberToGuess)
            {
                
                return true;
            }
            
            else if(input > numberToGuess)
            {
                Console.WriteLine("Raad lager");
            }
            else
            {
                Console.WriteLine("Raad hoger");
            }
            return false;
           
        }

    }
}
