Console.Clear();
Console.WriteLine("Program för att registrera för och efternamn");
Console.WriteLine("Angre förnamn: ");
string förnamn = Console.ReadLine();
Console.WriteLine("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);

if (förnamn == "Melvin")
{
    Console.WriteLine("Vad trevligt att du är tillbaka!");
}

if (efternamn == "boholm käll")
{
    Console.WriteLine("Vackert efternamn!")
}
