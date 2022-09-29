Random slump = new Random();
int slumptal = slump.Next(1, 100);



int gissa = 0;
while (slumptal != gissa)
{
    Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
    gissa = int.Parse(Console.ReadLine());
    int antalGissningar = 0;
    antalGissningar++;
    if (slumptal > gissa)
    {
        Console.WriteLine("För lågt!");
    }
    if (slumptal < gissa)
    {
        Console.WriteLine("För högt!");
    }

    else if (slumptal == gissa)
    {
        Console.WriteLine("Grattis, Rätt tal! Det tog dig " + antalGissningar + " antal gissningar");
    }
}
