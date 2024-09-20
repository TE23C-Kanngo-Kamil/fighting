Console.WriteLine("Write your name:");
string name = Console.ReadLine();

while (name.Length < 3)
{
    Console.WriteLine("Write your name, damn it!");
    name = Console.ReadLine();
}

Console.WriteLine($"Hello {name}!");
Console.ReadLine();

int heroHp = 100;
int villainHp = 100;

string heroName = "HERO";
string villainName = "VILLAIN";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("---- ===== NEW ROUND ==== ----");
    Console.WriteLine($"{heroName}: {heroHp} {villainName}: {villainHp}");

    int heroDamage = generator.Next(21);
    villainHp -= heroDamage;
    villainHp = Math.Max(0, villainHp);
    Console.WriteLine($"{heroName} dealt {heroDamage} damage to {villainName}");

    int villainDamage = generator.Next(21);
    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);
    Console.WriteLine($"{villainName} dealt {villainDamage} damage to {heroName}");
}