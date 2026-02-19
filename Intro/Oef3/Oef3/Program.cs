// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Het huidige jaartal is {DateTime.Today.Year}");
Console.WriteLine("Wat is je geboortejaar?");
string input = Console.ReadLine();
int birthYear = int.Parse(input);
int age = DateTime.Today.Year - birthYear;

Console.WriteLine($"Je leeftijd is momenteel {age}");
