namespace Bewerkingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double som = 0;

            Console.Write("Getal 1: ");
            if(!int.TryParse(Console.ReadLine(), out int number1)) // EXAMEN/PE VRAAG!!!
            {
                Console.WriteLine("Dit is geen geldig getal");
                return;
            }

            Console.Write("Getal 2: ");
            if (!int.TryParse(Console.ReadLine(), out int number2)) // EXAMEN/PE VRAAG!!!
            {
                Console.WriteLine("Dit is geen geldig getal");
                return;
            }
            Console.Write("Kies een bewerking (* / + -): ");
            string operatorSign = Console.ReadLine();

            switch(operatorSign)
            {
                case "+":
                    som = number1 + (double)number2;
                    break;
            
            
                case "-":
                    som = number1 - (double)number2;
                    break;

                case "/":
                    som = number1 / (double)number2;
                    break;

                case "*":
                    som = number1 * (double)number2;
                    break;

                default:
                    Console.WriteLine("Bewerking niet ondersteund");
                    return;
            }
            Console.WriteLine($"Resultaat: {som:F2}");

        }
    }
}
