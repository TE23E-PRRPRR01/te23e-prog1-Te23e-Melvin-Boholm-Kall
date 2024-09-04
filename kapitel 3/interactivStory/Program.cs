Console.Clear();

int health = 100;

Console.WriteLine("Du står i ett rum, ett svärd ligger på golvet. Plockar du upp det? (y/n)");
string answer = Console.ReadLine();
if (answer.ToLower() == "y")
{
    Console.WriteLine("Du plockar upp svärdet och kollar dig runtomkring, du är i ett mörkt rum med två dörrar. Går du in i dörr 1 eller 2? (1/2)");
    answer = Console.ReadLine();
    if (answer == "1")
    {
        Console.WriteLine("Du öppnar dörren och ser en gigantisk spindel. Dräper du den? (y/n)");
        answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
            Console.WriteLine("Du dräpte spindeln, men inte utan skada. Du förlorar 30 liv.");
            health -= 30;
            Console.WriteLine($"Din hälsa är nu {health}.");
            Console.WriteLine("Du står inför 2 dörrar ännu en gång. Vilken dörr går du igenom? (1/2)");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Du öppnar dörr ett fast finner inget. Du tar ett par steg framåt för att vara 100% säker att rummet var tomt.");
                Console.WriteLine("Du hör dörren stängas bakom dig, du är fast i det här rummet. Du letar efter en utväg men finner ingen, du dör av svält.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Du går igenom dörr två och finner en väg ut. Grattis, du överlevde!");
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("Du försöker smyga förbi spindeln, men den attackerar dig och du förlorar 50 liv.");
            health -= 50;
            Console.WriteLine($"Din hälsa är nu {health}.");
            if (health <= 0)
            {
                Console.WriteLine("Du dog av dina skador.");
                Environment.Exit(0);
            }
            Console.WriteLine("Du lyckas fly från rummet och står nu inför två dörrar igen. Vilken dörr går du igenom? (1/2)");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Du öppnar dörr ett och hittar inget. Du fastnar i rummet och dör av svält.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Du går igenom dörr två och finner en väg ut. Grattis, du överlevde!");
                Environment.Exit(0);
            }
        }
    }
    else
    {
        Console.WriteLine("Du öppnar dörr två och ser en ljus korridor. Du går vidare och finner en utgång. Grattis, du överlevde!");
        Environment.Exit(0);
    }
}
else
{
    Console.WriteLine("Du plockar inte upp svärdet och blir attackerad av en dold fiende. Du har inget att försvara dig med och dör.");
    Environment.Exit(0);
}
