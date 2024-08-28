using System.IO.Compression;

Console.Clear();
Console.WriteLine("Vad är ditt namn?");
string namn = Console.ReadLine();
Console.WriteLine("Vad har du för kön?");
string kön = Console.ReadLine();
Console.WriteLine("Vad gillar du för mat? ");
string mat = Console.ReadLine();
Console.WriteLine("Vart gillar du spendera din tid?");
string plats = Console.ReadLine();
Console.WriteLine("Vart kommer du ifrån");
string land = Console.ReadLine();

Console.Clear();

if ((land == "sverige") ||  (land == "Sverige"))
{

    Console.WriteLine($"{namn} är en liten {kön} som gillar att käka {mat} och vara {plats} för att man kommer från det underbara landet {land}.");


} 
else
{

    Console.WriteLine($"{namn} är en liten {kön} som gillar att käka {mat} och vara {plats} för att man kommer från {land}. Dem som kommer från {land} är lite lustiga och gillar att bete sig på det viset.");


}

Console.ReadKey();
