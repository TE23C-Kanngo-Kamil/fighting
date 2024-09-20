Console.WriteLine("Skriv ditt namn:");
string name = Console.ReadLine();

Console.WriteLine($"Hej {name}!");
if (name == "")
{
    Console.WriteLine("Skriv ditt namn för i helvete!")
    name = Console.ReadLine();
}

Console.ReadLine();