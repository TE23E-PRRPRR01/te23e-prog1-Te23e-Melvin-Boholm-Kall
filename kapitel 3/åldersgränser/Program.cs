// Åldersgränser
Console.Clear();

Console.WriteLine("Ange din längd i cm: ");
string längdText = Console.ReadLine();

int längd = int.Parse(längdText);


if (längd < 110)
{
    Console.WriteLine("Du får inte åka något eftersom du är för kort.");
}
else if (längd >= 110 && längd < 140)
{
    Console.WriteLine("Då får du åka bergochdalbanorna för små barn.");
}
else if (längd >= 140 && längd <= 200)
{
    Console.WriteLine("Då får du åka alla bergochdalbanorna.");
}
else if (längd > 200)
{
    Console.WriteLine("Du får inte åka någon bergochdalbana eftersom du är för lång.");
}
