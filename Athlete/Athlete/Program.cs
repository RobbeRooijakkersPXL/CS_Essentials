namespace Athlete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person fastestAthlete = null;

            string inputName;
            int inputTime = 0;

            do
            {
                Console.Write("Name: ");
                inputName = Console.ReadLine();

                Console.Write("Tijd:");
                if (!int.TryParse(Console.ReadLine(), out int time)){

                    Console.WriteLine("Ongeldige input");
                    continue;
                }
                if (fastestAthlete == null || time < fastestAthlete.LapTime)
                {
                    fastestAthlete = new Person()
                    {
                        Name = inputName,
                        LapTime = time
                    };
                }

            } while (!inputName.Equals("STOP"));


            Console.Write($"Name of the athlete {fastestAthlete.Name}");
            

            Console.Write($"Time runned {fastestAthlete.LapTime}");
            
        }
    }
}
