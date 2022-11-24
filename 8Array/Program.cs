double[] Gehaltsstufe = new double[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
Console.WriteLine("Vordiensjahre rechner");
Console.WriteLine("Wieviel Vordiensjahre haben sie?");
double Vordienstzeit = Convert.ToDouble(Console.ReadLine());
double gehalt = 0;

if (Vordienstzeit == 0)
{
    Vordienstzeit += 1;
}
if (Vordienstzeit > 10)
{
    Vordienstzeit = 10;
}

switch (Vordienstzeit)
{
    case 1:
        gehalt = Gehaltsstufe[0];
        break;
    case 2:
        gehalt = Gehaltsstufe[1];
        break;
    case 3:
        gehalt = Gehaltsstufe[2];
        break;
    case 4:
        gehalt = Gehaltsstufe[3];
        break;
    case 5:
        gehalt = Gehaltsstufe[4];
        break;
    case 6:
        gehalt = Gehaltsstufe[5];
        break;
    case 7:
        gehalt = Gehaltsstufe[6];
        break;
    case 8:
        gehalt = Gehaltsstufe[7];
        break;
    case 9:
        gehalt = Gehaltsstufe[8];
        break;
    case 10:
        gehalt = Gehaltsstufe[9];
        break;
}
Console.WriteLine($"{gehalt:C2}");