// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");
// Ange antal
Console.Write("Hur många tal?: ");
int antal = int.Parse(Console.ReadLine());
Console.Write("Minimumtal?: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Maximumtal?: ");
int max = int.Parse(Console.ReadLine());
// Loopa 5 ggr
for (var i = 0; i < antal; i++)
{
    // Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max);
    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}