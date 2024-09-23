// See https://aka.ms/new-console-template for more information
// Ett frågesport spel

Console.Clear();

Console.WriteLine("Vad heter du? ");
string namn = Console.ReadLine().ToLower();

int poäng = 0;

Console.WriteLine($"Välkommen {namn}!\n");
Thread.Sleep(1000);

// Fråga 1
Console.WriteLine("Vilket är världens sämsta spel?");
Console.WriteLine("A. Genshin Impact");
Console.WriteLine("B. Fortnite");
Console.WriteLine("C. Osu");
Console.WriteLine("D. Alla tidigare nämnda spel.");
Console.WriteLine("Svar: ");
string svar = Console.ReadLine().ToLower();
if (svar == "d")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 2
Console.WriteLine("Vilket är världens största hav?");
Console.WriteLine("A. Atlanten");
Console.WriteLine("B. Stilla havet");
Console.WriteLine("C. Indiska oceanen");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "b")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 3
Console.WriteLine("Vad heter Sveriges kung?");
Console.WriteLine("A. Carl XVI Gustaf");
Console.WriteLine("B. Gustav Vasa");
Console.WriteLine("C. Olof Skötkonung");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "a")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 4
Console.WriteLine("Vilket år blev Sverige medlem i EU?");
Console.WriteLine("A. 1995");
Console.WriteLine("B. 2001");
Console.WriteLine("C. 1989");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "a")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 5
Console.WriteLine("Vad heter världens högsta berg?");
Console.WriteLine("A. Kilimanjaro");
Console.WriteLine("B. Mount Everest");
Console.WriteLine("C. K2");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "b")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 6
Console.WriteLine("Vilket land har störst befolkning i världen?");
Console.WriteLine("A. Indien");
Console.WriteLine("B. Kina");
Console.WriteLine("C. USA");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "b")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 7
Console.WriteLine("Vilken färg har smaragder?");
Console.WriteLine("A. Blå");
Console.WriteLine("B. Röd");
Console.WriteLine("C. Grön");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "c")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 8
Console.WriteLine("Vad är huvudstaden i Frankrike?");
Console.WriteLine("A. Paris");
Console.WriteLine("B. Lyon");
Console.WriteLine("C. Marseille");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "a")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 9
Console.WriteLine("Vilket djur är snabbast på land?");
Console.WriteLine("A. Leopard");
Console.WriteLine("B. Gepard");
Console.WriteLine("C. Antilop");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "b")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Fråga 10
Console.WriteLine("Hur många planeter finns det i solsystemet?");
Console.WriteLine("A. 7");
Console.WriteLine("B. 8");
Console.WriteLine("C. 9");
Console.WriteLine("Svar: ");
svar = Console.ReadLine().ToLower();
if (svar == "b")
{
    poäng += 1;
    Console.WriteLine($"Rätt svar! Du har {poäng} poäng.");
}
else
{
    Console.WriteLine($"Fel svar! Du har {poäng} poäng.");
}
Thread.Sleep(2000);
Console.Clear();

// Poängbedömning
Console.WriteLine($"{namn}, du fick totalt {poäng} poäng!");
if (poäng == 10)
{
    Console.WriteLine($"{namn}, du är en riktig quiz-mästare!");
}
else if (poäng > 5)
{
    Console.WriteLine($"Bra jobbat, {namn}!");
}
else
{
    Console.WriteLine($"Bättre lycka nästa gång, {namn}!");
}