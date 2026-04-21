namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[100];
            int count = 0;     
            int number = 2;   

            while (count < 100)
            {
                if (IsPrime(number))
                {
                    primeNumbers[count] = number;
                    count++;
                }

                number++;
            }

            int index = 0;

            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write($"{primeNumbers[index]}  ");
                    index++;
                }
                Console.WriteLine();
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= number / 2; i++)
                {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    
    }
}
