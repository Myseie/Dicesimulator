Random rnd  = new Random();

Console.Write("Skriv in hur många gånger du vill kasta tärningarna : ");

string input = Console.ReadLine();

int number  = int.Parse(input);

for (int i = 0; i < number; i++)
{
    int dice = rnd.Next(1, 7);
    int dice2 = rnd.Next(1, 7);

    Console.WriteLine($"Kast {i + 1}: Tärning 1 = {dice}, Tärning 2 = {dice2}");
}