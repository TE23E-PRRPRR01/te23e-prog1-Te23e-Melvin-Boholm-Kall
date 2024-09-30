// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Slumpa stad ur städer");

//Skapa en lista av städer
List<string> städer = ["Stockholm", "New York City", "Chicago", "New Delhi", "London", "Tokyo", "Beijing", "Rio de janiero", "Riyadh", "versailles"];


int antal = 0;

while(antal != 5)
{
int index = Random.Shared.Next(0, 9);

string stad = städer[index];

Console.WriteLine($"Den slumpade staden är: {stad}");
antal ++;
}
