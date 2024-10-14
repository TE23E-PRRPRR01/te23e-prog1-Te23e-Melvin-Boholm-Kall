// Använda listor för skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter, tex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan

frukter[0] = "banan";

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista

foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri sak (4st)
// Skriv ut varje sak på samma rad

List<string> albums = ["The College Dropout", "Late Registration", "Graduation", "808s & Heartbrake"];

foreach (var album in albums)
{
    Console.Write($"{album}, ");
}

for (int i = 0; i < albums.Count; i++)
{
    Console.Write($"{albums[i]} ");
}

// Skapa ett register
// En tom lista

Console.Clear();

List<string> namnLista = [];

// While-loop

while (true)
{
    System.Console.Write("\nAnge ett namn: ");
    string namn = Console.ReadLine();

    namnLista.Add(namn);

    // Skriv ut hela listan på en rad

    foreach (var namnet in namnLista)
    {
        Console.Write($"{namnet}, ");
    }


    
}
