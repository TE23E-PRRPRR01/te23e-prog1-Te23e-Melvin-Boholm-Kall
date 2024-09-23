// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Text editor");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;




while(true)
{

    Console.WriteLine($"""
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta programmet
    Välj ett alternativ ovan:
    """);

    string val = Console.ReadLine();

  if (val == "1")
  {
    Console.Clear();
    Console.WriteLine("Skriv en text: ");
    string text = Console.ReadLine();
    Console.WriteLine("Vad ska filen heta?");
    string namn = Console.ReadLine();
     File.WriteAllText($"{namn}.txt", text);
  }
  else if (val == "2")
  {

    try
    {
        Console.Clear();
        Console.WriteLine("Namn på filen: ");
        string namn = Console.ReadLine();
        string text = File.ReadAllText($"{namn}.txt");
        Console.WriteLine($"{text}"); 
    }
    catch (Exception ex)
    {
        Console.Clear();
    }
  }
  else if (val == "3")
  {     
    Console.Clear();
    Console.WriteLine("Adjö");
    break;
  }
  else
  {
    Console.WriteLine("Försök igen");
  }

}
