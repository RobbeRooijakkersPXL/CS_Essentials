namespace Faculteit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            int product = 1;
            int getal;

            do 
            {
                Console.WriteLine("Geef een getal");
                input = Console.ReadLine();


            } while (!int.TryParse(input, out getal));


            
            for (int i = getal; i >= 1; i--)
            {

                product *= i;
                    
            }
            Console.WriteLine($"Factulteit van {getal} is {product}");
            
            
            
        }
    }
}
