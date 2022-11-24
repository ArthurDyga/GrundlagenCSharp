Console.WriteLine("Prämien Rechner");
double Prämie;
Console.WriteLine("Seit wielange arbeiten sie schon?(In jahre)");
double Jahre = Convert.ToDouble(Console.ReadLine());
double Prmie;
if (Jahre < 10)
{
    switch (Jahre)
    {
        case < 3:
            Prmie = 0;
            Console.WriteLine($"Prämie = {Prmie:C2} Euro pro Jahr");
            break;
        case >= 3:
            Prmie = 150;
            Prmie = 150 * (Jahre-2);
            Console.WriteLine($"Prämie = {Prmie:C2} Euro pro Jahr");
            break;
    }
}
double Zähler = Jahre - 9;
double Prm = 150;
if (Jahre >= 10)
{
    Prämie = 1050;
    while (Zähler > 0)
    {
        Prm += 10;
        Prämie += Prm;
        --Zähler;

    }
    Console.WriteLine($"Ihre Prämie liegt bei {Prämie:C2} im Jahr");
}