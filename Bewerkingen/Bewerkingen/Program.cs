namespace Bewerkingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;

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
                    som = number1 + number2;
                    Console.WriteLine($"Resultaat: {som}");
                    break;
            
            
                case "-":
                    som = number1 - number2;
                    Console.WriteLine($"Resultaat: {som}");
                    break;

                case "/":
                    som = number1 / number2;
                    Console.WriteLine($"Resultaat: {som}");
                    break;

                case "*":
                    som = number1 * number2;
                    Console.WriteLine($"Resultaat: {som}");
                    break;

            }

        }
    }
}
