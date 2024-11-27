Console.Clear();

List<string> namn = ["Eli", "Alexander", "Skogen", "Viktor", "Sara"];

Console.WriteLine($"Min kompisar är: {string.Join(", ", namn)}");

Console.WriteLine(" ");

List<string> städer = ["Stockholm", "Solna", "Jackobsberg", "Flemmingsberg", "Stora Essingen"];
Console.WriteLine($"Fem orter ({string.Join(", ", städer)}) i sverige");

Console.WriteLine(" ");

List<int> uddaTal = [1497, 1587, 2017, 915, 1785];
Console.WriteLine($"Fem udda årtal är: '{string.Join("', '", uddaTal)}");

Console.WriteLine(" ");

List<string> listaNamn = ["Tim", "Malte", "Oscar", "Melker", "Elias"];
Console.WriteLine("Första namnet: " + listaNamn[0]);
Console.WriteLine("Sista namnet: " + listaNamn[4]);

Console.WriteLine(" ");

List<string> drycker = ["Coca-Cola", "Julmust", "Fanta", "Pepsi", "7up"];
Console.WriteLine("Mina favoritdrycker:");
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1}. {drycker[i]}");
}

List<int> ålder = [4, 18, 23, 44, 2];

Console.WriteLine(" ");

Console.WriteLine("Födelseår: ");
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1}. {ålder[i]}");
}

Console.WriteLine(" ");

Console.Write("Nuvarande namn: ");

Console.WriteLine(string.Join(", ", namn));


Console.Write("Nytt namn att lägga till: ");

string nyttNamn = Console.ReadLine();

namn.Add(nyttNamn);

Console.Write($"Ny lista på namn: {namn}");

