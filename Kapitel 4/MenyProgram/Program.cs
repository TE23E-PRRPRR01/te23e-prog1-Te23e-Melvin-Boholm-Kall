// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;




while(true)
{

    Console.WriteLine($"""
    1. Omvandla en text till versaler
    2. Omvandla en text till gemener
    3. Avsluta
    Välj ett alternativ ovan:
    """);

    string val = Console.ReadLine();

  if (val == "1")
  {
    Console.WriteLine("Skrive en text: ");
    string text = Console.ReadLine().ToUpper();
    Console.WriteLine($"Output: {text}");
  }
  else if (val == "2")
  {
    Console.WriteLine("Skrive en text: ");
    string text = Console.ReadLine().ToLower();
    Console.WriteLine($"Output: {text}");
  }
  else if (val == "3")
  {
        Console.WriteLine("Adjö");
        break;
  }
  else
  {
    Console.WriteLine("Försök igen");
  }

}