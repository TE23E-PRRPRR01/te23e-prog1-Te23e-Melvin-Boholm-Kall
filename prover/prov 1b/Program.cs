// See https://aka.ms/new-console-template for more information

int skattesatsen = 0;

Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");


// Nvändarens namn
Console.Write("Vad heter du? ");
string namn = Console.ReadLine();


while (true)
{
    Console.WriteLine("Ange din bruttolön i kroner: ");
    int bruttolön = int.Parse(Console.ReadLine());
    if (bruttolön < 10000 || bruttolön > 1000000)
    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }
    else
    {
        // vad är skattesatsen?

        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22;
        }
        if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33;
        }
        if (bruttolön >= 515000)
        {
            skattesatsen = 53;
        }


        // skatteuträkning
        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        Console.WriteLine($"Din nettolön blir {nettolön}kr. Uträkning baserad på bruttolön {bruttolön}kr och marginalskatten {skattesatsen}%.");
    }


    Console.WriteLine("Vill du göra ny beräkning? (j/n)");
    string svar = Console.ReadLine().ToLower().Trim();
    if (svar == "j")
    {
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Adjö");
        break;
    }

}
