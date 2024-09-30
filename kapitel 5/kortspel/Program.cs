// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Slumpa kort ur en kortlek");

//Skapa en lista kort
List<string> kortlek = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K"];


int antal = 0;

while(antal != 5)
{
int index = Random.Shared.Next(0, kortlek.Count);

//Plocka ut det sjunde kortet
string kort = kortlek[index];

kortlek.RemoveAt(index);

Console.WriteLine($"Det slumpade kortet är: {kort}");
antal ++;
}
