// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Ett litet namnregister");


while (true)
{
    Console.Clear();

    // Visa en meny
    Console.WriteLine("""
    1. Registrera namn
    2. Skriva ut alla nman
    3. Töm registret
    4. Avsluta
    Ange ditt val: 
    """);

    string val = Console.ReadLine().ToLower().Trim();

    if (val == "1" || val == "registrera namn")
    {
        Console.Clear();
        Console.Write("Vad heter personen? ");
        string namn = Console.ReadLine();
        File.AppendAllText($"namn.txt", namn + ", ");

    }
    else if (val == "2" || val == "skriva ut alla namn")
    {
        try
        {
            Console.Clear();
            string text = File.ReadAllText("namn.txt");
            if (text == "")
            {
                Console.WriteLine("Registret är tomt.");
                Thread.Sleep(2000);

            }
            else
            {
                Console.WriteLine($"{text}");
                Console.Write("Vill du fortsätta? (j/n) ");
                val = Console.ReadLine();
                if (val == "j")
                {
                    Console.Clear();
                }
                else
                {
                    Environment.Exit(0);
                }
            }



        }
        catch (Exception ex)
        {
            System.Console.Write("Det finns ingen namnlista ännu.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
    else if (val == "3" || val == "töm registret")
    {
        File.WriteAllText($"namn.txt", "");
        Console.WriteLine("Registret har tömts.");
        Thread.Sleep(2000);
    }
    else if (val == "4" || val == "avsluta")
    {
        Console.WriteLine("Adjö");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Skriv i rätt format.");
        Thread.Sleep(2000);
        Console.Clear();
    }

}