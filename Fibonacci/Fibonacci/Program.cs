namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[12];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 10; i++)
            {
                fibonacci[i + 2] = fibonacci[0 + i] + fibonacci[1 + i];
            }

            foreach(int element in fibonacci)
            {
                Console.WriteLine(element);
            }

        }
    }
}
