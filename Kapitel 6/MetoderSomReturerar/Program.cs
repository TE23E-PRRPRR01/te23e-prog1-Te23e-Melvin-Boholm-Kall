// MAIN

Console.Clear();

Console.WriteLine(Addera(1, 2));

string namn = "Malte";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

Console.WriteLine(Mult(5, 5));

Console.WriteLine(Div(10, 5));

Längst("HEj", "Hej1");

Console.WriteLine("");
Console.Write("Ange ett tal: ");
int nyTal = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();

// METODER

static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}

static string VändText(string text)
{
    string OmvändText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        OmvändText += text[i];
    }
    return OmvändText;
}

static double Mult(double tal1, double tal2)
{

    double summa = tal1 * tal2;

    return summa;
}

static double Div(double tal1, double tal2)
{
    double summa = tal1 / tal2;

    return summa;
}

static void Längst(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        Console.WriteLine($"Text 1 '{text1}' är längre än text 2 '{text2}'");
    }
    else
    {
        Console.WriteLine($"Text 2 '{text2}' är längre än text 1 '{text1}'");
    }
}

static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {

        string textSomBlirTal = Console.ReadLine();

        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break; 
        }
        else
        {
            Console.WriteLine("Fel! ANge ett heltal");
        }
    }

    return tal;    
}
