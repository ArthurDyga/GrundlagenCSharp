double Prämie;
Console.WriteLine("Seit wielange arbeiten sie schon?(In jahre)");
double Jahre = Convert.ToDouble(Console.ReadLine());
if (Jahre < 10)
{
    switch (Jahre)
    {
        case < 3:
            Console.WriteLine($"Keine Prämie");
            break;
        case >= 3:
            Console.WriteLine($"Prämie = 150 Euro pro Jahr");
            break;
    }
}
if (Jahre > 10)
{
    Prämie = ((Jahre - 10) * 10)+150;
    Console.WriteLine($"Ihre Prämie liegt bei {Prämie:C2} im Jahr");
}