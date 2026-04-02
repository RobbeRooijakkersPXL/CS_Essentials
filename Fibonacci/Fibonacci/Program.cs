namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[12];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < 12; i++)
            {
                //fibonacci[i + 2] = fibonacci[0 + i] + fibonacci[1 + i];

                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            foreach(int element in fibonacci)
            {
                Console.WriteLine(element);
            }

        }
    }
}
