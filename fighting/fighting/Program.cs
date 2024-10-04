Console.WriteLine("Write your name:");
string name = Console.ReadLine();

while (name.Length < 3)
{
    Console.WriteLine("Write your name, damn it!");
    name = Console.ReadLine();
}

Console.WriteLine($"Hello, {name}!");
Console.ReadLine();

int heroHp = 100;
int villainHp = 100;

string heroName = "Drake";
string villainName = "Kendrick";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("---- ===== NEW ROUND ==== ----");
    Console.WriteLine($"{heroName}: {heroHp} {villainName}: {villainHp}");

    int heroDamage = generator.Next(21);
    if (heroDamage == 0)
    {
        Console.WriteLine($"{heroName} missed!");
    }
    else
    {
        villainHp -= heroDamage;
        villainHp = Math.Max(0, villainHp);
        Console.WriteLine($"{heroName} dealt {heroDamage} damage to {villainName}");
    }
    int villainDamage = generator.Next(21);
    if (villainDamage == 0)
    {
        Console.WriteLine($"{villainName} missed!");
    }
    else
    {
        heroHp -= villainDamage;
        heroHp = Math.Max(0, heroHp);
        Console.WriteLine($"{villainName} dealt {villainDamage} damage to {heroName}");
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

Console.WriteLine("---- ===== BATTLE OVER ==== ----");

if (heroHp == 0 && villainHp == 0)
{
    Console.WriteLine("It is a draw!");
}
else if (heroHp == 0)
{
    Console.WriteLine($"{villainName} is the winner!");
}
else
{
    Console.WriteLine($"{heroName} is the winner!");
}

Console.WriteLine($"Thank you for playing, {name}! Press any key to exit");
Console.ReadKey();