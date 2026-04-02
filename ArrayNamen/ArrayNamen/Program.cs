namespace ArrayNamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[6];

            Console.WriteLine("Geef de namen van je lectoren in: ");

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{i+1}: ");
                name[i] = Console.ReadLine();
            }

            Console.WriteLine();

            foreach(string element in name)
            {
                Console.WriteLine(element);
            }
        }
    }
}
