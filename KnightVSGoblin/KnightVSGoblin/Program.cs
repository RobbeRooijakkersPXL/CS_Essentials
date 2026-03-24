namespace KnightVSGoblin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Knight VS Goblin");
            Console.WriteLine("---------------------");
            Console.ResetColor();
            Random rng = new Random();

            int knightHealth;
            int goblinHealth;
            
            goblinHealth = rng.Next(1, 101); //Upperbound telt niet mee dus: 100

            bool isValid;
            do
            {
                isValid = true;
                Console.Write("Enter the healtpoints for your knight: ");
                string inputHealth = Console.ReadLine();

                if (!int.TryParse(inputHealth, out knightHealth) || knightHealth < 1 || knightHealth > 100) {

                    Console.WriteLine("Ongeldige input, geef een getal tussen 1 en 100");
                    isValid = false;
                }
                /*else
                {
                    isValid = true;
                }*/
            } while (isValid == false);


            int roundCount = 0;
            int poisenActivated = 0;
            int criticalCounter = 0;
            int goblinCounterAttack = 0;

            do
            {
                roundCount++;
                Console.Clear();
                Console.WriteLine($"Round: {roundCount}, fight!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"knightHealth: {knightHealth}");
                for(int i = 0; i < knightHealth; i++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
                Console.WriteLine($"goblinHealth: {goblinHealth}");
                for (int i = 0; i < goblinHealth; i++)
                {
                    Console.Write("█");
                }
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("Choose your next move carefully");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Attack");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. Heal");
                Console.ResetColor();
                if(roundCount % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("3. POISEN ATTACK (Shown only after every 5 rounds");
                    Console.ResetColor();

                }
                if (criticalCounter == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("4. CRITICAL ATTACK BABYYY");
                    Console.ResetColor();
                }

                Console.Write("Enter your choice: ");
                string inputChoice = Console.ReadLine();

                int knightAttack = rng.Next(11, 16);
                int goblinAttack = rng.Next(5, 16);
                int poisenAttack = 5;
                

                switch (inputChoice)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ATTACKED!");
                        

                        goblinHealth -= knightAttack;

                        if(knightAttack > 10)
                        {
                            criticalCounter++;
                        }
                        else
                        {
                            criticalCounter = 0;
                        }

                        

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"You attacked the goblin for {knightAttack} damage");
                        Console.ResetColor();

                        if(goblinHealth > 0)
                        {
                            knightHealth -= goblinAttack;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The goblin attacked you for: {goblinAttack} damage");
                            Console.ResetColor();

                        }
                        
                        break;

                    case "2":

                        int healing = 10;
                        knightHealth += healing;
                        knightHealth -= goblinAttack;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"You healed yourself for {healing} points");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"The goblin attacked you for: {goblinAttack} damage");
                        Console.ResetColor();

                        break;
                       
                    case "3":
                        if(roundCount % 5 == 0)
                        {
                            poisenActivated = 2;
                            knightHealth -= goblinAttack;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"The goblin attacked you for: {goblinAttack} damage");
                            Console.ResetColor();
                        }
                        else
                        {
                            knightHealth -= 5;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input, Health -5 points");
                            Console.ResetColor();
                        }
                        break;

                    case "4":
                        if (criticalCounter == 3)
                        {
                            knightAttack = rng.Next(10, 21);
                            goblinHealth -= knightAttack;

                            goblinHealth -= knightAttack;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"You attacked the goblin for an extra {knightAttack} CRITICAL damage");
                            Console.ResetColor();
         
                        }
                        else
                        {
                            knightHealth -= 5;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input, Health -5 points");
                            Console.ResetColor();
                        }
                        


                        break;

                    default:
                        knightHealth -= 5;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input, Health -5 points");
                        Console.ResetColor();
                        
                        break;
                }

                
                if (poisenActivated > 0)
                {
                    
                    goblinHealth -= poisenAttack;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"A hidden poisen attack has attacked the goblin for {poisenAttack}");
                    Console.ResetColor();
                    poisenActivated--;
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.ResetColor();




            } while (knightHealth > 0 && goblinHealth > 0);


            if(knightHealth <= 0)
            {
                //Knight Verloren
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The knight has fallen, you are defeated by a goblin dude...");
                Console.ResetColor();
            }
            else
            {
                //Knight Gewonnen
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You killed a goblin... Congratz Bro... ");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
            Console.ResetColor();
        }
    }
}
