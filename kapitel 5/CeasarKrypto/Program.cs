// Ett program för kryptering med Ceasar-chiffer
using System.Runtime.ConstrainedExecution;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Ceasar-chiffer");

// Alfabetet
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en mening
Console.Write("Ange en mening: ");
string mening = Console.ReadLine().ToUpper();


// Ange en nyckel
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

// Loopa igenom meddeleandet bokstav-för-bokstav
foreach (var bokstav in mening)
{

    // Hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);


    // OM bokstaven finns i alfabetet
    if (index != -1)
    {
        // Ceasar-kryptering, addera en nyckel (tex 2)
        int nyIndex = index+nyckel;

        

        // Plocka ut bokstaven för ny index
        char krypteradBokstav = alfabetet[nyIndex];

        Console.Write($"{krypteradBokstav}");
    }
    else
    {
        Console.WriteLine("Bokstaven finns inte i alfabetet.");
        Environment.Exit(0);
    }

}

