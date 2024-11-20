
while (true)
{
    
    Console.Clear();

    // Frågar användaren efter deras namn
    Console.Write("Vad heter du? ");
    //Lägger namnet i en string
    string namn = Console.ReadLine();

    Console.WriteLine(); // Radbrytning för läsbarhet

    // 3. Låt användaren bestämma antalet repetitioner
    int repetitioner = 0;

    // Använd en while-loop för att säkerställa korrekt inmatning
    while (true)
    {
        Console.Write("Hur många gånger ska loopen köras? (1-10): ");
        if (int.TryParse(Console.ReadLine(), out repetitioner) && repetitioner >= 1 && repetitioner <= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett heltal mellan 1 och 10.");
        }
    }

    Console.WriteLine(); // Radbrytning
    for (int i = 0; i < repetitioner; i++)
    {
        Console.WriteLine($"{i + 1}. {namn}");
    }

    Console.WriteLine(); // Radbrytning

    // 4. Gör beräkningar efter loopen
    double användarTal = 0;

    // Säkerställ att användaren matar in ett giltigt tal
    while (true)
    {
        Console.Write("Mata in ett tal: ");
        if (double.TryParse(Console.ReadLine(), out användarTal))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett giltigt tal.");
        }
    }

    // Beräkningar och utskrifter
    Console.WriteLine("\nResultat:");
    Console.WriteLine($"Multiplicerat med 2: {användarTal * 2}");
    Console.WriteLine($"Dividerat med 2: {användarTal / 2}");
    Console.WriteLine($"Adderat med 2: {användarTal + 2}");
    Console.WriteLine($"Subtraherat med 2: {användarTal - 2}");
    Console.WriteLine($"Kvadraten av talet: {Math.Pow(användarTal, 2)}");
    Console.WriteLine($"Talet upphöjt till tre: {Math.Pow(användarTal, 3)}");

    Console.WriteLine(); // Radbrytning

    // Möjlighet att köra om programmet
    Console.Write("Vill du köra programmet igen? (j/n): ");
    string svar = Console.ReadLine()?.ToLower();

    if (svar == "j")
    {
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Avslutar programmet.");
        Environment.Exit(0);
    }
}
