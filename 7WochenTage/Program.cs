Console.WriteLine("Wochentag Berechner");
Console.WriteLine();
Console.WriteLine("Jahr");
int Jahr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Monat");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tag");
int q = Convert.ToInt32(Console.ReadLine());
int K = Jahr % 100;
int J = Jahr / 100;
int h;
string Ergebniss = "A";

if (m == 1)
{
    m += 13;
}

else if (m == 2)
{
    m += 14;
}

h = (q + (((m + 1) * 26) / 10)+K + (K / 4) + (J / 4) - 2 * J);
h %= 7;

if (h < 0)
{
    h += 7;
}

switch (h)
{
    case 1:
        Ergebniss = "Sonntag";
        break;
    case 2:
        Ergebniss = "Montag";
        break;
    case 3:
        Ergebniss = "Dienstag";
        break;
    case 4:
        Ergebniss = "Mittwoch";
        break;
    case 5:
        Ergebniss = "Donnerstag";
        break;
    case 6:
        Ergebniss = "Freitag";
        break;
    case 7:
        Ergebniss = "Samsatag";
        break;
}
Console.WriteLine($"Der wochentag lautet: {Ergebniss}");