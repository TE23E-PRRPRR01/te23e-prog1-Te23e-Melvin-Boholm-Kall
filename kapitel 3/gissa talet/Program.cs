// Gissa talet spel

Console.Clear();

Random randNummer = new Random();

int nummer = randNummer.Next(1, 101);

int försök = 0;


while (true)
{
    Console.Write("Gissa ett tal 1-100: ");

    string gissningText = Console.ReadLine();
    int gissniing = int.Parse(gissningText);

    if (gissniing == nummer)    
    {
        Console.Clear();
        Console.WriteLine("Du gissa rätt!!");
        Console.WriteLine($"Försök: {försök}");
        
        Environment.Exit(0);

    }
    else
    {
        Console.Clear();
        Console.WriteLine("Du gissa fel :(");

        försök += 1;

        Console.WriteLine($"Försök: {försök}");

        if (gissniing > nummer)
        {

            Console.WriteLine("Ditt gissa för högt");

        }
        else
        {
            Console.WriteLine("Du gissa för lågt");
        }
    }

}
