// See https://aka.ms/new-console-template for more information
Console.Clear();

int health = 100;

Console.WriteLine("Du står i ett rum, ett svärd ligger på golvet. Plockar du upp det? (y/n)");
string answer = Console.ReadLine();
if (answer == "y")
{
    Console.WriteLine("Du plockar upp svärdet och kollar dig runtomkring, du är i ett murkt rum med två dörrar. Går du in i dörr 1 eller 2? (1/2)");
    answer = Console.ReadLine();
    if (answer == "1")
    {
        Console.WriteLine("Du öppnar dörr två och ser en gigantisk spindel. Dräper du den? (y/n)");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("Du dräpte spindeln, men inte utan skada. Du förlorar 30 liv.");
            health -= 30;
            Console.WriteLine("Du står inför 2 dörrar ännu en gång. Vilken dörr går du igenom? (1/2)");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Du öppnar dörr ett fast finner inget. Du tar ett par steg framåt för att vara 100% säker att rummet var tomt.");
                Console.WriteLine("Du hör durren stängas bakom dig, du är fast i det här rummet. Du letar efter en utväg fast finner ingen, du dör av svält");
                Environment.Exit(0);
            }
            else
            {
                
            }

        }
        else
        {
            
        }
    }
    else
    {
        
    }
}
else
{
    
}