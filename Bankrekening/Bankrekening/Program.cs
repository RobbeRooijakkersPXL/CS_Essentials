using Bankrekening.Models;
namespace Bankrekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bankrekening");
            Console.ResetColor();

            string input;
            decimal amount;
            
            BankAccount bankaccount = new BankAccount();
            ShowBalance(bankaccount);


            do 
            {
                
                do
                {
                    Console.Write("Geef het bedrag (+ voor storting, - voor afhaling): ");
                    input = Console.ReadLine();

                    if (input.Equals("STOP", StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }

                } while (!decimal.TryParse(input, out amount));

                if (amount > 0)
                {
                    IncreaseAmount(bankaccount, amount);
                    ShowBalance(bankaccount);


                }
                else if (amount < 0)
                {
                    
                    DecreaseAmount(bankaccount, amount);
                    ShowBalance(bankaccount);

                }


            } while (true);
            
        }

        static void IncreaseAmount(BankAccount bankaccount,decimal amount) 
        {
            bankaccount.Deposit(amount);
        
        }

        static void DecreaseAmount(BankAccount bankaccount, decimal amount) 
        {
            bankaccount.Withdraw(amount);
        }

        static void ShowBalance(BankAccount bankaccount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Saldo: {bankaccount.CurrentBalance:c} ");
            Console.ResetColor();        
        }
    }
}
