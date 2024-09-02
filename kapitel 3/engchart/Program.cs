// Program som simulerar kända engineering flowchart
Console.Clear();
Console.WriteLine("Välkommer till ingenjörens flödesschema");


Console.WriteLine($"""

                           -   ,--_--.
               -           \      `.
                      -     "-_ _   \
     -                         / F   )
                   -     -    / / `--'
              -              / /
                   -        / /
            -            __/ /
                        /,-pJ
           -        _--"-L ||
                  ,"      "//
     -           /  ,-'''.//\
                /  /     // J____
               J  /     // L/----\
   .           F J     //__//^---'
     `     ___J  F    '----| |
  `       J---|  F         F F
`   `. `   `--J  L        J  F
    .   .`     L J       J  F
       .  .    J  \    ,"  F
         .  `.` \  "--"  ,"
            ` ``."-____-"

""");

Console.WriteLine("Does it move ? (y/n)");
string answer = Console.ReadLine();

if (answer == "y")
{
    Console.Write("Should it? (y/n)");
    string shouldIT = Console.ReadLine();
    if (shouldIT == "y")
    {
        Console.WriteLine("No problem");
    }
    else
    {
        Console.WriteLine("duct tape");
    }
}
else
{
    Console.Write("Should it? (y/n)");
    string shouldIt = Console.ReadLine();
    if (shouldIt == "y")
    {
        Console.WriteLine("Please use WD-40");
    }
    else
    {
        Console.WriteLine("No problem");
    }
}