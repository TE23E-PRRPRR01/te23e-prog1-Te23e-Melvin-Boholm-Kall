// MAIN

Console.Clear();

// Skriv ett meddelande verikalt
string meddelande = "Måndag!";

//SkrivVertikalt(meddelande);

//Console.WriteLine("");

// Skriv ett meddelande verikalt nr 2
string meddelande1 = "Tisdag!";
//SkrivVertikalt(meddelande1);

//Console.WriteLine("");

// Skriv ett meddelande verikalt nr 3
string meddelande2 = "Onsdag!";
//SkrivVertikalt(meddelande2);

// METODER

static void SkrivVertikalt(string text)
{
    // Skriv ett meddelande verikalt
        for (var i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }
}

SkrivVertikalt("Hej!");

static void RitaKvadrat(int sidlängd)
{
    for (var i = 0; i < sidlängd; i++)
    {
        for (var j = 0; j < sidlängd; j++)
        {
            Console.Write("# ");
        }
        Console.WriteLine("");
    }
}


RitaKvadrat(3);

static void UpprepaText(string text, int antal)
{
 
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }

}

UpprepaText("Hej", 4);

static void ÖverförCTillF(int C)
{

    int F = C * 9/5 + 32;

    Console.WriteLine($"{C} grader celsius motsvarar {F} grader Fahrenheit");

}

ÖverförCTillF(30);

static void Tärning(int antal)
{

    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }

}

Tärning(5);
