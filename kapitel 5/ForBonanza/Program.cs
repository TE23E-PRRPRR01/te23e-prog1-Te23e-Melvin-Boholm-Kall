while (true)
{
    Console.Clear();

    Console.WriteLine("-- Iterera över en sekvens av siffror --");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i + 1);
    }

    Console.WriteLine("\n-- Ange startvärde och slutvärde --");
    int start = 0;
    int slut = 0;

    Console.Write("Ange startvärde: ");
    while (!int.TryParse(Console.ReadLine(), out start))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Ange startvärde: ");
    }

    Console.Write("Ange slutvärde: ");
    while (!int.TryParse(Console.ReadLine(), out slut))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Ange slutvärde: ");
    }

    for (int i = start; i <= slut; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("\n-- Summera alla siffror i en sekvens --");
    int summeraStart = 0;
    int summeraSlut = 0;

    Console.Write("Start: ");
    while (!int.TryParse(Console.ReadLine(), out summeraStart))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Start: ");
    }

    Console.Write("Slut: ");
    while (!int.TryParse(Console.ReadLine(), out summeraSlut))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Slut: ");
    }

    int sum = 0;
    for (int i = summeraStart; i <= summeraSlut; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Summan av siffrorna {summeraStart} till {summeraSlut} är: {sum}");

    Console.WriteLine("\n-- Summera alla jämna siffror i en sekvens --");
    int jämnStart = 0;
    int jämnSlut = 0;

    Console.Write("Start: ");
    while (!int.TryParse(Console.ReadLine(), out jämnStart))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Start: ");
    }

    Console.Write("Slut: ");
    while (!int.TryParse(Console.ReadLine(), out jämnSlut))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Slut: ");
    }

    sum = 0;
    for (int i = jämnStart; i <= jämnSlut; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine($"Summan av jämna siffror från {jämnStart} till {jämnSlut} är: {sum}");

    Console.WriteLine("\n-- Jämna och udda siffror från 1 till 20 --");
    Console.WriteLine("Jämna siffror:");
    for (int i = 2; i <= 20; i += 2)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\nUdda siffror:");
    for (int i = 1; i < 20; i += 2)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine("\n\n-- Multiplikationstabell --");
    int tal = 0;

    Console.Write("Ange ett tal: ");
    while (!int.TryParse(Console.ReadLine(), out tal))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Ange ett tal: ");
    }

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{tal} x {i} = {tal * i}");
    }

    Console.WriteLine("\n-- Mönster med stjärnor --");
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\n-- Julgran --");
    int rows = 0;

    Console.Write("Ange antal rader: ");
    while (!int.TryParse(Console.ReadLine(), out rows))
    {
        Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
        Console.Write("Ange antal rader: ");
    }

    for (int i = 1; i <= rows; i++)
    {
        for (int j = 0; j < rows - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < (2 * i - 1); j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < rows - 1; j++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("**");
    }

    Console.WriteLine("\nVill du avsluta? (j/n).");
    if (Console.ReadLine()?.ToLower() == "j")
    {
        Thread.Sleep(2000);
        break;
    }
}
